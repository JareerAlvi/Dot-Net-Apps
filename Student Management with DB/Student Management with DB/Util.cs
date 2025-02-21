using System.Drawing;

namespace Student_Management_with_DB
{
    public class Util
    {
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
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); //trying to parse email in correct using an in built class
                return true;
                //upper statement would throw exception in cas of invalid format...and control will transfer to catch block without coming on this line
            }
            catch
            {
                return false;
            }
        }
    }
}
