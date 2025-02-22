using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace Student_Management_with_DB
{
    public class Util
    {
       public static string  connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

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
                // Basic format validation
                var addr = new MailAddress(email);
                //upper statement would throw exception in cas of invalid format...and control will transfer to catch block without coming on this line


                // Regular expression to enforce domain extensions like .com, .edu, .org, etc.
                string pattern = @"^[^@\s]+@[^@\s]+\.(com|edu|org|net|gov|pk|info)$";
                /*
   Explanation of the pattern:
   ^         -> Start of the string
   [^@\s]+   -> Matches one or more characters that are NOT '@' or whitespace
   @         -> Ensures the presence of a single '@' symbol
   [^@\s]+   -> Matches one or more characters after '@', ensuring no spaces or multiple '@'
   \.        -> Matches a literal dot '.' (escaped because '.' in regex means "any character")
   (com|edu|org|net|gov|pk|info) -> Ensures the domain extension is one of the listed options
   $         -> End of the string
*/
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);  //true only when both checks are true
            }
            catch
            {
                return false;
            }
        }



        public static void ShowAll(DataGridView grdStudents)
        {
            try
            {
                IList<SMSStudent> lstStudents = new List<SMSStudent>();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "SELECT * FROM tbStudents";

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

                    grdStudents.DataSource = lstStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ShowAll_Function: {ex.Message}");
            }
        }
    }
}
