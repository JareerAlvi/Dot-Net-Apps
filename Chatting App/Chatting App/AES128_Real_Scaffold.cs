using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
namespace Chatting_App
{
    
    /*
     Example Usage:-

                string encryptedData = AES.Encrypt("1234", "1234");
            try
            {
                // Encrypt the data and display it as a base64 string
                MessageBox.Show($"Encrypted: {encryptedData}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            try
            {
                // Encrypt the data and display it as a base64 string
                string DecryptedData = AES.Decrypt(encryptedData, "1234");
                MessageBox.Show($"Encrypted: {DecryptedData}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
     */
    public static class AES
    {
        public static string key = "1234567890abcdef1234567890abcdef";
        // S-Box and Inverse S-Box
        private static readonly byte[] SBox = {
        0x63, 0x7c, 0x77, 0x7b, 0xf0, 0x6f, 0x6b, 0x68, 0x4f, 0x53, 0x53, 0x51, 0x67, 0x6f, 0x5b, 0x56, 0x2f,
        0x1f, 0x47, 0x33, 0x11, 0x07, 0x17, 0x73, 0x61, 0x10, 0x1b, 0x6f, 0x28, 0x25, 0x47, 0x27, 0x11
    };

        private static readonly byte[] InvSBox = {
        0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb, 0x7c,
        0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0x51, 0x12, 0x8f, 0x5b, 0x8b, 0x9b, 0x39, 0x98
    };

        // Rcon for key expansion
        private static readonly byte[] Rcon = {
        0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x1b, 0x36
    };

        // XOR Helper Method for Key Expansion
        private static byte[] XOR(byte[] array1, byte[] array2)
        {
            byte[] result = new byte[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = (byte)(array1[i] ^ array2[i]);
            }
            return result;
        }

        // Substitution Layer - S-box transformation
        private static byte[] SubWord(byte[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = SBox[word[i]];
            }
            return word;
        }

        // Rotation Layer - Word rotation
        private static byte[] RotWord(byte[] word)
        {
            byte[] result = new byte[word.Length];
            Array.Copy(word, 1, result, 0, word.Length - 1);
            result[word.Length - 1] = word[0];
            return result;
        }

        // Key Expansion Method
        public static byte[][] KeyExpansion(byte[] key)
        {
            int keySize = key.Length;
            int blockSize = 16;
            int rounds = 10;
            int expandedKeySize = (rounds + 1) * blockSize;
            byte[][] expandedKey = new byte[expandedKeySize][];
            byte[] temp = new byte[4];
            int k = 0;

            // Copy the original key
            for (int i = 0; i < keySize; i++)
            {
                expandedKey[i] = new byte[] { key[i] };
            }

            while (k < expandedKeySize)
            {
                temp = expandedKey[k - 1];
                if (k % keySize == 0)
                {
                    temp = SubWord(RotWord(temp));
                    temp[0] ^= Rcon[k / keySize - 1];
                }
                else if (keySize > 6 && k % 4 == 0)
                {
                    temp = SubWord(temp);
                }
                expandedKey[k] = XOR(expandedKey[k - keySize], temp);
                k++;
            }

            return expandedKey;
        }

        // AddRoundKey Method
        private static byte[,] AddRoundKey(byte[,] state, byte[] roundKey)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] ^= roundKey[i + j * 4];
                }
            }
            return state;
        }

        // AES Encryption
        public static string Encrypt(string data, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Convert the data to a byte array
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);

                // Ensure the key is exactly 16 bytes (128-bit)
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                // If the key is shorter than 16 bytes, pad it; if it's longer, truncate it
                Array.Resize(ref keyBytes, 16);

                aesAlg.Key = keyBytes;
                aesAlg.IV = new byte[16]; // Initialize IV to all zeros (not recommended for production)

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(dataBytes, 0, dataBytes.Length);
                            cs.FlushFinalBlock();
                        }

                        // Return the encrypted byte array as a base64 string
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }


        public static string Decrypt(string encryptedBase64, string key)
        {


          
            using (Aes aesAlg = Aes.Create())
            {
                // Convert the encrypted Base64 string to a byte array
                byte[] cipherBytes = Convert.FromBase64String(encryptedBase64);

                // Convert the key to bytes and ensure it's 16 bytes long
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                Array.Resize(ref keyBytes, 16);

                aesAlg.Key = keyBytes;
                aesAlg.IV = new byte[16]; // Same zero IV used during encryption

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream ms = new MemoryStream(cipherBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
        public static string GenerateAESKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256; // 256-bit AES key
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key);
            }
        }

        // SubBytes Transformation
        private static byte[,] SubBytes(byte[,] state)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    state[i, j] = SBox[state[i, j]];
                }
            }
            return state;
        }

        // ShiftRows Transformation
        private static byte[,] ShiftRows(byte[,] state)
        {
            byte temp;
            // Row 1 shifts 1 byte to the left
            temp = state[1, 0];
            state[1, 0] = state[1, 1];
            state[1, 1] = state[1, 2];
            state[1, 2] = state[1, 3];
            state[1, 3] = temp;

            // Row 2 shifts 2 bytes to the left
            temp = state[2, 0];
            state[2, 0] = state[2, 2];
            state[2, 2] = temp;
            temp = state[2, 1];
            state[2, 1] = state[2, 3];
            state[2, 3] = temp;

            // Row 3 shifts 3 bytes to the left
            temp = state[3, 0];
            state[3, 0] = state[3, 3];
            state[3, 3] = state[3, 2];
            state[3, 2] = state[3, 1];
            state[3, 1] = temp;

            return state;
        }

        // MixColumns Transformation (not implemented here for simplicity)
        private static byte[,] MixColumns(byte[,] state)
        {
            // This is an advanced operation that's not shown here
            return state;
        }
    }

}
