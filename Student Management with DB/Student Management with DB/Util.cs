using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Student_Management_with_DB
{
    public class Util
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static Image ResizeImage(Image img, Size newSize)
        {
            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newSize.Width, newSize.Height);
            }
            return bmp;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|edu|org|net|gov|pk|info)$";

            /*
            Explanation:
            ^                  -> Start of the string
            [a-zA-Z0-9._%+-]+  -> Local part: allows letters, numbers, dots, underscores, %, +, and - 
            @                  -> Ensures the presence of '@'
            [a-zA-Z0-9.-]+     -> Domain part: allows letters, numbers, dots, and hyphens
            \.                 -> Matches a literal dot '.'
            (com|edu|org|net|gov|pk|info) -> Allowed domain extensions
            $                  -> End of the string
            */

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }


        public static IList<SMSStudent> GetAllStudents(string whereClause = "", string orderClause = "")
        {
            IList<SMSStudent> lstStudents = new List<SMSStudent>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = $"SELECT * FROM tbStudents {whereClause} {orderClause}";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        SMSStudent objStudent = new SMSStudent()
                        {
                            StudentID = int.Parse(sqlDataReader["StudentID"].ToString()),
                            First_Name = sqlDataReader["FirstName"].ToString(),
                            Last_Name = sqlDataReader["LastName"].ToString(),
                            Age = int.Parse(sqlDataReader["Age"].ToString()),
                            Grade = sqlDataReader["Grade"].ToString(),
                            Email = sqlDataReader["Email"].ToString(),
                            DOB = DateTime.Parse(sqlDataReader["DateOfBirth"].ToString())
                        };

                        lstStudents.Add(objStudent);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ShowAll_Function: {ex.Message}");
            }

            return lstStudents;
        }
    }
}
