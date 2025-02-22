using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace Student_Management_with_DB
{
    public partial class HomePage : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public HomePage()
        {
            InitializeComponent();
            //btnBack.BackgroundImage = ResizeImage(Image.FromFile("C:\\Users\\MY GUEST\\Downloads\\back.png"), btnBack.Size);
            string[] validGrades = { "A", "B", "C", "D", "F" };
            cbGrades.DataSource = validGrades;
            Util.ShowAll(grdStudents);
        }

        private bool ValidateStudentInput()
        {
            lbFNameMsg.Text = lbLNameMsg.Text = lbAgeMsg.Text = lbGradeMsg.Text = lbEmailMsg.Text = lbDOBMsg.Text = string.Empty;

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



            if (!Util.IsValidEmail(tbEmail.Text.Trim()))
            {
                lbEmailMsg.Text = "Please enter a valid Email.";
                isValid = false;
            }

            if (dateTimePicker.Value > DateTime.Now)
            {
                lbDOBMsg.Text = "Date of Birth cannot be in the future.";
                isValid = false;
            }

            return isValid;
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
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
                        sqlCommand.Parameters.AddWithValue("@Grade", cbGrades.SelectedItem);
                        sqlCommand.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            tbFirstName.Text = tbLastName.Text = tbAge.Text  = tbEmail.Text = "";
                            cbGrades.SelectedItem = "A";
                            dateTimePicker.Value = DateTime.Now;
                            Util.ShowAll(grdStudents);
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
            if (grdStudents.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = grdStudents.CurrentRow;

                tbFirstName.Text = selectedRow.Cells["First_Name"].Value.ToString();
                tbLastName.Text = selectedRow.Cells["Last_Name"].Value.ToString();
                tbAge.Text = selectedRow.Cells["Age"].Value.ToString();
                cbGrades.SelectedItem = selectedRow.Cells["Grade"].Value.ToString();
                tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                dateTimePicker.Value = DateTime.Parse(selectedRow.Cells["DOB"].Value.ToString());

                btnAddStudent.Visible = btnUpdateStudent.Visible = false;
                btnSubmitUpdate.Visible = true;
            }
            else if (grdStudents.SelectedRows.Count > 0)
            {
                MessageBox.Show("Only One Student's Inmformation can be Updated at a time", "Students");
            }
            else
            {
                MessageBox.Show("Please Select a Student First");
            }
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentInput())
                return;

            int studentId = (int)grdStudents.CurrentRow.Cells["StudentID"].Value;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE StudentID <> @StudentID AND Email = @Email", sqlConnection))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@StudentID", studentId);
                        checkEmailCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());

                        int emailCount = (int)checkEmailCmd.ExecuteScalar();
                        if (emailCount > 0) //&& tbEmail.Text != grdStudents.CurrentRow.Cells["Email"].Value.ToString()) //Check so that email isnt duplicated and if email isnt changed during update...the false ,message doesnt appears
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
                    sqlCommand.Parameters.AddWithValue("@StudentID", studentId);
                    sqlCommand.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Age", int.Parse(tbAge.Text));
                    sqlCommand.Parameters.AddWithValue("@Grade", cbGrades.SelectedItem);
                    sqlCommand.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //Returning to previous states
                        btnSubmitUpdate.Visible = false;
                        btnUpdateStudent.Visible = btnAddStudent.Visible = true;
                        tbFirstName.Text = tbLastName.Text = tbAge.Text  = tbEmail.Text = string.Empty;
                        cbGrades.SelectedItem = "A";
                        dateTimePicker.Value = DateTime.Now;
                        Util.ShowAll(grdStudents);
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
