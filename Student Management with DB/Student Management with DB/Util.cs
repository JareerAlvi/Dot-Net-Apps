using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

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
                var addr = new System.Net.Mail.MailAddress(email); //trying to parse email in correct using an in built class
                return true;
                //upper statement would throw exception in cas of invalid format...and control will transfer to catch block without coming on this line
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
