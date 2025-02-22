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
                        SMSStudent student = CreateStudentFromInput();

                        sqlConnection.Open();
                        using (SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE Email = @Email", sqlConnection))
                        {
                            checkEmailCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());

                            int emailCount = (int)checkEmailCmd.ExecuteScalar();
                            if (emailCount > 0)
                            {
                                MessageBox.Show("This email is already registered. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandText = @"
                INSERT INTO tbStudents(FirstName, LastName, Age, Grade, Email, DateOfBirth)
                VALUES(@FirstName, @LastName, @Age, @Grade, @Email, @DateOfBirth)";

                        sqlCommand.Parameters.AddWithValue("@FirstName", student.First_Name);
                        sqlCommand.Parameters.AddWithValue("@LastName", student.Last_Name);
                        sqlCommand.Parameters.AddWithValue("@Age", student.Age);
                        sqlCommand.Parameters.AddWithValue("@Grade", student.Grade);
                        sqlCommand.Parameters.AddWithValue("@Email", student.Email);
                        sqlCommand.Parameters.AddWithValue("@DateOfBirth", student.DOB);

                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = "";
                            cbGrades.SelectedItem = "A";
                            dateTimePicker.Value = DateTime.Now;
                            Util.ShowAll(grdStudents);
                            MessageBox.Show("Student has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private SMSStudent CreateStudentFromInput()
        {
            return new SMSStudent()
            {
                First_Name = tbFirstName.Text.Trim(),
                Last_Name = tbLastName.Text.Trim(),
                Age = int.Parse(tbAge.Text),
                Grade = cbGrades.SelectedItem.ToString(),
                Email = tbEmail.Text,
                DOB = dateTimePicker.Value.Date
            };
        }

        private void PopulateFormFieldsFromSelectedRow(DataGridViewRow selectedRow)
        {
            tbFirstName.Text = selectedRow.Cells["First_Name"].Value.ToString();
            tbLastName.Text = selectedRow.Cells["Last_Name"].Value.ToString();
            tbAge.Text = selectedRow.Cells["Age"].Value.ToString();
            cbGrades.SelectedItem = selectedRow.Cells["Grade"].Value.ToString();
            tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            dateTimePicker.Value = DateTime.Parse(selectedRow.Cells["DOB"].Value.ToString());
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = grdStudents.CurrentRow;
                PopulateFormFieldsFromSelectedRow(selectedRow);

                btnAddStudent.Visible = false;
                btnUpdateStudent.Visible = false;
                btnSubmitUpdate.Visible = true;
            }
            else if (grdStudents.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only one student's information can be updated at a time.", "Update Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a student first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                if (grdStudents.SelectedRows.Count == 1)
                {
                    try
                    {
                        // Get the selected student's ID from the grid
                        int studentID = int.Parse(grdStudents.CurrentRow.Cells["StudentID"].Value.ToString());

                        // Create an updated student object from the form inputs
                        SMSStudent updatedStudent = CreateStudentFromInput();

                        // Update the student in the database
                        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                        {
                            sqlConnection.Open();
                            string updateQuery = @"
                    UPDATE tbStudents 
                    SET FirstName = @FirstName, 
                        LastName = @LastName, 
                        Age = @Age, 
                        Grade = @Grade, 
                        Email = @Email, 
                        DateOfBirth = @DOB 
                    WHERE StudentID = @StudentID";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection))
                            {
                                updateCommand.Parameters.AddWithValue("@FirstName", updatedStudent.First_Name);
                                updateCommand.Parameters.AddWithValue("@LastName", updatedStudent.Last_Name);
                                updateCommand.Parameters.AddWithValue("@Age", updatedStudent.Age);
                                updateCommand.Parameters.AddWithValue("@Grade", updatedStudent.Grade);
                                updateCommand.Parameters.AddWithValue("@Email", updatedStudent.Email);
                                updateCommand.Parameters.AddWithValue("@DOB", updatedStudent.DOB);
                                updateCommand.Parameters.AddWithValue("@StudentID", studentID);

                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Util.ShowAll(grdStudents); // Refresh the grid to show updated data
                                }
                                else
                                {
                                    MessageBox.Show("No student was updated. Please check the selected student.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }

                        // Reset the form
                        btnAddStudent.Visible = true;
                        btnUpdateStudent.Visible = true;
                        btnSubmitUpdate.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
