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
    public partial class ManageStudents : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public ManageStudents()
        {
            InitializeComponent();
            cbSort.DataSource = new List<string> { "First Name", "Last Name", "Grade" };
        }

        private bool ValidateStudentInput(string studentID, string firstName, string lastName, int age, string grade, string email, DateTime dob, out string errorMessage)
        {
            errorMessage = string.Empty;
            List<string> errors = new List<string>();

            /*if (int.TryParse(st))
                errors.Add("First Name must be provided.");*/

            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("First Name must be provided.");

            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("Last Name must be provided.");

            if (age <= 0)
                errors.Add("Please enter a valid positive number for Age.");

            if (string.IsNullOrWhiteSpace(grade))
                errors.Add("Grade must be provided.");

            if (!Util.IsValidEmail(email.Trim()))
                errors.Add("Please enter a valid Email.");

            if (dob > DateTime.Now)
                errors.Add("Date of Birth cannot be in the future.");

            if (errors.Count > 0)
            {
                errorMessage = string.Join("\n", errors);
                return false;
            }

            return true;
        }


        //Failed validation for file data entered manually
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a search keyword.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAll_Click(object sender, EventArgs e)
        {
            grdStudents.DataSource = Util.GetAllStudents();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string selectedCriteria = cbSort.SelectedItem.ToString();
            string orderByClause = " ORDER BY ";

            if (selectedCriteria == "First Name")
            {
                orderByClause += "FirstName";
            }
            else if (selectedCriteria == "Last Name")
            {
                orderByClause += "LastName";
            }
            else if (selectedCriteria == "Grade")
            {
                orderByClause += "Grade";
            }

            grdStudents.DataSource = Util.GetAllStudents(orderClause: orderByClause);
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void btnBack2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}