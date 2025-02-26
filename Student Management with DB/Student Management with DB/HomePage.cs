using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
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
            cbSort.DataSource = new List<string>{ "First Name", "Last Name","Grade","Age","Email","Date of Birth"};
            cbSortOrder.DataSource = new List<string> { "Ascending", "Descending" };

            cbGrades.DataSource = validGrades;
            grdStudents.DataSource = Util.GetAllStudents();
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
                            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                            cbGrades.SelectedItem = "A";
                            dateTimePicker.Value = DateTime.Now;

                            grdStudents.DataSource = Util.GetAllStudents();

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
                newStudentPanel.Visible = true;
                lbTitle.Text = "Update Student";
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
                                    grdStudents.DataSource = Util.GetAllStudents();
                                    tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                                    cbGrades.SelectedItem = "A";
                                    dateTimePicker.Value = DateTime.Now;
                                }

                                else
                                {
                                    MessageBox.Show("No student was updated. Please check the selected student.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }

                        // Reset the form

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
               grdStudents.DataSource= Util.GetAllStudents();
                return;
            }

            IList<SMSStudent> lstStudents = new List<SMSStudent>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                // Using LIKE for searching substrings
                string query = "SELECT * FROM tbStudents WHERE FirstName LIKE @Value OR LastName LIKE @Value OR Email LIKE @Value";
                SqlCommand searchCommand = new SqlCommand(query, sqlConnection);
                searchCommand.Parameters.AddWithValue("@Value", "%" + searchValue + "%");

                SqlDataReader sqlDataReader = searchCommand.ExecuteReader();

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

                sqlDataReader.Close();
                grdStudents.DataSource = lstStudents;
            }
        }

        private void btnAddPannel_Click(object sender, EventArgs e)
        {
            newStudentPanel.Visible = true;

        }



        private void btnBack2_Click_1(object sender, EventArgs e)
        {
            newStudentPanel.Visible = false;
            btnSubmitUpdate.Visible = false;
            lbTitle.Text = "New Student";

        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one Student to Delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> lstIdsToDelete = new List<int>();
            foreach (DataGridViewRow currentrow in grdStudents.SelectedRows)
            {
                lstIdsToDelete.Add((int)currentrow.Cells["StudentID"].Value);
            }

            // Confirmation message box
            DialogResult result = MessageBox.Show(    //A variable which stores dufferent values returned from message box
                "Are you sure you want to delete the selected student(s)?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "DELETE FROM tbStudents WHERE StudentID IN ("
                        + string.Join(",", lstIdsToDelete) + ")";
                    sqlCommand.ExecuteNonQuery();

                    grdStudents.DataSource = Util.GetAllStudents();
                    MessageBox.Show("Students Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDelete_Click1: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (fdExportCSV.ShowDialog() == DialogResult.OK) //if user clicks on OK then the Import Functionality is performed else wise Not
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbStudents", sqlConnection);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        string filePath = fdExportCSV.FileName; //the default file name set in designer

                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine("StudentID,FirstName,LastName,Age,Grade,Email,DateOfBirth");

                            while (reader.Read())
                            {
                                string csvLine = $"{reader["StudentID"]},{reader["FirstName"]},{reader["LastName"]}," +
                                                 $"{reader["Age"]},{reader["Grade"]},{reader["Email"]},{reader["DateOfBirth"]}";
                                writer.WriteLine(csvLine);
                            }
                        }

                        reader.Close();
                        MessageBox.Show($"Student records exported successfully to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (fdImportCSV.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fdImportCSV.FileName;
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            reader.ReadLine();

                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] data = line.Split(',');
                                if (data.Length != 7) continue;
                                //ValidateStudentInput();   //Failed validation for file data entered manually
                                int studentID = int.Parse(data[0]);
                                string firstName = data[1];
                                string lastName = data[2];
                                int age = int.Parse(data[3]);
                                string grade = data[4];
                                string email = data[5];
                                DateTime dob = DateTime.Parse(data[6]);

                                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE StudentID = @ID", sqlConnection);
                                checkCmd.Parameters.AddWithValue("@ID", studentID);
                                int count = (int)checkCmd.ExecuteScalar();

                                if (count == 0)
                                {
                                    SqlCommand insertCmd = new SqlCommand("INSERT INTO tbStudents (StudentID, FirstName, LastName, Age, Grade, Email, DateOfBirth) " +
                                                                          "VALUES (@ID, @FirstName, @LastName, @Age, @Grade, @Email, @DOB)", sqlConnection);
                                    insertCmd.Parameters.AddWithValue("@ID", studentID);
                                    insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                                    insertCmd.Parameters.AddWithValue("@LastName", lastName);
                                    insertCmd.Parameters.AddWithValue("@Age", age);
                                    insertCmd.Parameters.AddWithValue("@Grade", grade);
                                    insertCmd.Parameters.AddWithValue("@Email", email);
                                    insertCmd.Parameters.AddWithValue("@DOB", dob);

                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Student records imported successfully.", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grdStudents.DataSource = Util.GetAllStudents();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing from CSV: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (fdExportCSV.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            IList<SMSStudent> lstStudents = Util.GetAllStudents();
            fdExportCSV.Filter = "All files (*.*)|*.*";
            fdExportCSV.FileName = "report.txt"; //Default Name
            fdExportCSV.Title = "Report";

            try
            {
                if (lstStudents.Count == 0)
                {
                    MessageBox.Show("No students found to generate a report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalStudents = lstStudents.Count;
                double averageAge = lstStudents.Average(s => s.Age);

                Dictionary<string, int> gradeCounts = lstStudents.GroupBy(s => s.Grade)
                                                                 .ToDictionary(g => g.Key, g => g.Count());

                StringBuilder report = new StringBuilder();
                report.AppendLine("Student Report");
                report.AppendLine("----------------------------");
                report.AppendLine($"Total Students: {totalStudents}");
                report.AppendLine($"Average Age: {averageAge:F2}");
                report.AppendLine("\nGrade-wise Student Count:");

                foreach (var grade in gradeCounts)
                {
                    report.AppendLine($"Grade {grade.Key}: {grade.Value} students");
                }

                string reportPath = fdExportCSV.FileName;
                File.WriteAllText(reportPath, report.ToString());

                MessageBox.Show($"Report generated successfully", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbSearchMsg_Click(object sender, EventArgs e)
        {

        }


        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedItem == null || cbSortOrder.SelectedItem == null)
                return;

            string selectedCriteria = cbSort.SelectedItem.ToString();
            string sortOrder = cbSortOrder.SelectedItem.ToString(); // Ascending or Descending
            string orderByClause = " ORDER BY ";

            switch (selectedCriteria)
            {
                case "First Name":
                    orderByClause += "FirstName";
                    break;
                case "Last Name":
                    orderByClause += "LastName";
                    break;
                case "Grade":
                    orderByClause += "Grade";
                    break;
                case "Age":
                    orderByClause += "Age";
                    break;
                case "Email":
                    orderByClause += "Email";
                    break;
                case "Date of Birth":
                    orderByClause += "DateOfBirth";
                    break;
                default:
                    return; // If no valid column is selected, exit
            }

            // Append Ascending or Descending based on selection
            orderByClause += sortOrder == "Descending" ? " DESC" : " ASC";

            grdStudents.DataSource = Util.GetAllStudents(orderClause: orderByClause);
        }

    }
}
