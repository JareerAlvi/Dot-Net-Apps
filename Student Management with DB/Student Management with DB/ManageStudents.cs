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

            List<string> cbItemsSearch = new List<string> { "Name", "Email", "Grade" };
            List<string> cbItemsSort = new List<string> { "First Name", "Last Name", "Grade" };

            cbSearch.DataSource = cbItemsSearch;
            cbSort.DataSource = cbItemsSort;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IList<SMSStudent> lstStudents = new List<SMSStudent>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                if (cbSearch.SelectedItem != null)
                {
                    string selectedCriteria = cbSearch.SelectedItem.ToString();
                    SqlCommand searchCommand = sqlConnection.CreateCommand();

                    if (selectedCriteria == "Name")
                    {
                        if (string.IsNullOrWhiteSpace(tbSearch.Text))
                        {
                            MessageBox.Show("Provide a Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string Name = tbSearch.Text.ToString() + " ";
                        searchCommand.CommandText = "SELECT * FROM tbStudents WHERE FirstName = @Value";
                        searchCommand.Parameters.AddWithValue("@Value", Name.Substring(0, Name.IndexOf(" ")));
                    }
                    else if (selectedCriteria == "Email")
                    {
                        try
                        {
                            var addr = new System.Net.Mail.MailAddress(tbSearch.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a valid Email (e.g., abc@example.com)", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        searchCommand.CommandText = "SELECT * FROM tbStudents WHERE Email = @Value";
                        searchCommand.Parameters.AddWithValue("@Value", tbSearch.Text);
                    }
                    else if (selectedCriteria == "Grade")
                    {
                        string[] validGrades = { "A", "B", "C", "D", "F" };
                        if (!validGrades.Contains(tbSearch.Text.Trim().ToUpper()))
                        {
                            MessageBox.Show("Please enter a valid Grade (A, B, C, D, F).", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        searchCommand.CommandText = "SELECT * FROM tbStudents WHERE Grade = @Value";
                        searchCommand.Parameters.AddWithValue("@Value", tbSearch.Text);
                    }

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
                }

                grdStudents.DataSource = lstStudents;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Util.ShowAll(grdStudents);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            IList<SMSStudent> lstStudents = new List<SMSStudent>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                if (cbSort.SelectedItem != null)
                {
                    string selectedCriteria = cbSort.SelectedItem.ToString();
                    string orderByClause = "";

                    if (selectedCriteria == "First Name")
                    {
                        orderByClause = "ORDER BY FirstName";
                    }
                    else if (selectedCriteria == "Last Name")
                    {
                        orderByClause = "ORDER BY LastName";
                    }
                    else if (selectedCriteria == "Grade")
                    {
                        orderByClause = "ORDER BY Grade";
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid sorting criterion.", "Invalid Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand sortCommand = new SqlCommand($"SELECT * FROM tbStudents {orderByClause}", sqlConnection);
                    SqlDataReader sqlDataReader = sortCommand.ExecuteReader();

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
                }
                else
                {
                    MessageBox.Show("Please select a sorting option.", "No Option Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            grdStudents.DataSource = lstStudents;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count > 0)
            {
                List<int> idsToDelete = new List<int>();
                foreach (DataGridViewRow currentrow in grdStudents.SelectedRows)
                {
                    if (currentrow.Cells["StudentID"].Value != null)
                    {
                        idsToDelete.Add(int.Parse(currentrow.Cells["StudentID"].Value.ToString()));
                    }
                }

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        foreach (int currentid in idsToDelete)
                        {
                            SqlCommand sqlCommand = sqlConnection.CreateCommand();
                            sqlCommand.CommandText = "DELETE FROM tbStudents WHERE StudentID = @ID";
                            sqlCommand.Parameters.AddWithValue("@ID", currentid);
                            sqlCommand.ExecuteNonQuery();
                        }

                        Util.ShowAll(grdStudents);
                        MessageBox.Show("Students Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in btnDelete_Click1: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one Student to Delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbStudents", sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    string filePath = "students.csv";
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
                    MessageBox.Show("Student records exported successfully to students.csv", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string filePath = "students.csv";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File students.csv not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                    Util.ShowAll(grdStudents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing from CSV: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                IList<SMSStudent> lstStudents = new List<SMSStudent>();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbStudents", sqlConnection);
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

                string reportPath = "report.txt";
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