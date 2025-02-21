using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Classes2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Student_Management_with_DB
{
    public partial class HomePage : Form
    {
        string ConnectionString = "Server=localhost;Database=SMS;Integrated Security=True;";
        public HomePage()
        {
            InitializeComponent();
            btnBack.BackgroundImage = ResizeImage(Image.FromFile("C:\\Users\\MY GUEST\\Downloads\\back.png"), btnBack.Size);



        ShowAll();
        }
        private Image ResizeImage(Image img, Size newSize)
        {
            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newSize.Width, newSize.Height);
            }
            return bmp;
        }
        private bool IsValidEmail(string email)
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
        private bool ValidateStudentInput()
        {
            
            lbFNameMsg.Text = lbLNameMsg.Text = lbAgeMsg.Text = lbGradeMsg.Text =  lbEmailMsg.Text =  lbDOBMsg.Text = "";

            bool isValid = true; 


            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lbFNameMsg.Text = "First Name must be provided.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbLNameMsg.Text = "Last Name must be provided.";
                isValid = false;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age <= 0)
            {
                lbAgeMsg.Text = "Please enter a valid positive number for Age.";
                isValid = false;
            }

            string[] validGrades = { "A", "B", "C", "D", "F" };
            if (!validGrades.Contains(tbGrade.Text.Trim().ToUpper()))
            {
                lbGradeMsg.Text = "Please enter a valid Grade (A, B, C, D, F).";
                isValid = false;
            }
            if (!IsValidEmail(tbEmail.Text))
            {
                lbEmailMsg.Text = "Please enter a valid Email.";
                isValid = false;
            }

            if (!DateTime.TryParse(dateTimePicker.Text, out DateTime dob) || dob > DateTime.Now)
            {
                lbDOBMsg.Text = "Date of Birth cannot be in the future.";
                isValid = false;
            }

            return isValid;
        }

        private void ShowAll()
        {
            try
            {
                IList<Student> lstStudents = new List<Student>();

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "SELECT * FROM tbStudents";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Student objStudent = new Student()
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
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

     
            if(ValidateStudentInput())
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE Email = @Email", sqlConnection))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());

                            int emailCount = (int)checkEmailCmd.ExecuteScalar();
                            if (emailCount > 0)
                            {
                                MessageBox.Show("This email is already registered. Please use a different email.");
                                return; 
                            }
                        }
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandText = @"
            INSERT INTO tbStudents(FirstName, LastName, Age, Grade, Email, DateOfBirth)
            VALUES(@FirstName, @LastName, @Age, @Grade, @Email, @DateOfBirth)";

                            sqlCommand.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Age", int.TryParse(tbAge.Text, out int age) ? age : 0); 
                            sqlCommand.Parameters.AddWithValue("@Grade", tbGrade.Text.Trim().ToUpper());
                            sqlCommand.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value); 

                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbGrade.Text = tbEmail.Text = "";
                            dateTimePicker.Value = DateTime.Now;
                            ShowAll(); 
                            MessageBox.Show("Student Added Successfully");
                            }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

            }



        }
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {

            if (grdStudents.SelectedRows.Count == 1 )
            {
                tbFirstName.Text = grdStudents.CurrentRow.Cells["First_Name"].Value.ToString();
                tbLastName.Text = grdStudents.CurrentRow.Cells["Last_Name"].Value.ToString();
                tbAge.Text = grdStudents.CurrentRow.Cells["Age"].Value.ToString();
                tbGrade.Text = grdStudents.CurrentRow.Cells["Grade"].Value.ToString();
                tbEmail.Text = grdStudents.CurrentRow.Cells["Email"].Value.ToString();
                dateTimePicker.Value = DateTime.Parse(grdStudents.CurrentRow.Cells["DOB"].Value.ToString());
                btnAddStudent.Visible=btnUpdateStudent.Visible=false;
                btnSubmitUpdate.Visible=true;
            }

            else if (grdStudents.SelectedRows.Count > 0)
            {
                MessageBox.Show("Only One Student's Inmformation can be Updated at a time");

            }
            else
            {
                MessageBox.Show("Please Select a Student First");

            }
        }
        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                try
                {


                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        sqlConnection.Open();
                        using (SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE Email = @Email", sqlConnection))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());

                            int emailCount = (int)checkEmailCmd.ExecuteScalar();
                            if (emailCount > 0 && tbEmail.Text != grdStudents.CurrentRow.Cells["Email"].Value.ToString()) //Check so that email isnt duplicated and if email isnt changed during update...the false ,message doesnt appears
                            {
                                MessageBox.Show("This email is already registered. Please use a different email.");
                                return;
                            }
                        }

                        SqlCommand sqlCommand = sqlConnection.CreateCommand();



                        sqlCommand.CommandText = @"
                       UPDATE tbStudents 
                       SET FirstName = @FirstName, LastName = @LastName, Age = @Age, 
                       Grade = @Grade, Email = @Email, DateOfBirth = @DateOfBirth 
                       WHERE StudentID = @StudentID";
                        sqlCommand.Parameters.AddWithValue("@StudentID", int.Parse(grdStudents.CurrentRow.Cells["StudentID"].Value.ToString()));
                        sqlCommand.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Age", int.Parse(tbAge.Text));
                        sqlCommand.Parameters.AddWithValue("@Grade", tbGrade.Text.Trim().ToUpper());
                        sqlCommand.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //Returning to previous states
                            btnSubmitUpdate.Visible=false;
                            btnUpdateStudent.Visible=btnAddStudent.Visible = true;
                            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbGrade.Text = tbEmail.Text = "";
                            dateTimePicker.Value = DateTime.Now;
                            ShowAll();
                            MessageBox.Show("Student Information Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No changes were made. The information remains the same.");
                        }




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in btnUpdateFinal_Click: {ex.Message}");
                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ManageStudents manageStudents = new ManageStudents();
            manageStudents.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SMS_Authentication sMS_Authentication = new SMS_Authentication();
            sMS_Authentication.Show();
            this.Hide();


        }
    }
}
