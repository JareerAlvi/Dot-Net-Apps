using Classes2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Student_Management_with_DB
{
    public partial class ManageStudents: Form
    {
        string ConnectionString = "Server=localhost;Database=SMS;Integrated Security=True;";

        public ManageStudents()
        {
            InitializeComponent();
            btnBack2.BackgroundImage = ResizeImage(Image.FromFile("C:\\Users\\MY GUEST\\Downloads\\back.png"), btnBack2.Size);

            List<string> cbItemsSearch = new List<string> { "Name", "Email", "Grade" };
            List<string> cbItemsSort = new List<string> { "First Name", "Last Name", "Grade" };

            cbSearch.DataSource = cbItemsSearch;
            cbSort.DataSource = cbItemsSort;

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            IList<Student> lstStudents = new List<Student>();

            using (SqlConnection sqlConnection= new SqlConnection(ConnectionString))
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
                            MessageBox.Show("Provide a Name");
                            return;
                        }
                        string Name = tbSearch.Text.ToString() + " "; //ADDING Whiespace in case user gives corect input i.e FirstName
                        searchCommand.CommandText = "SELECT * FROM tbStudents WHERE FirstName = @Value";
                        searchCommand.Parameters.AddWithValue("@Value", Name.Substring(0,Name.IndexOf(" ")));
                    }
                    else if (selectedCriteria == "Email")
                    {
                        try
                        {
                            var addr = new System.Net.Mail.MailAddress(tbSearch.Text); 
   
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a valid Email(e.g abc@example.com)");
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
                            MessageBox.Show("Please enter a valid Grade (A, B, C, D, F).");
                            return;
                        }
                        searchCommand.CommandText = "SELECT * FROM tbStudents WHERE Grade = @Value";
                        searchCommand.Parameters.AddWithValue("@Value", tbSearch.Text);
                    }

                    SqlDataReader sqlDataReader = searchCommand.ExecuteReader();

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

                    sqlDataReader.Close();
                }

                grdStudents.DataSource = lstStudents;
            }

        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {

            IList<Student> lstStudents = new List<Student>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
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
                        MessageBox.Show("Please select a valid sorting criterion.");
                        return;
                    }

                    SqlCommand sortCommand = new SqlCommand($"SELECT * FROM tbStudents {orderByClause}", sqlConnection);
                    SqlDataReader sqlDataReader = sortCommand.ExecuteReader();

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

                    sqlDataReader.Close();
                }
                else
                {
                    MessageBox.Show("Please select a sorting option.");
                    return;
                }
            }

            grdStudents.DataSource = lstStudents;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count > 0) //Checking if User has selected a row or not
            {
                List<int> idsToDelete = new List<int>(); //Making a list in case user selects many students
                foreach (DataGridViewRow currentrow in grdStudents.SelectedRows) // a variable of a built in data type that stored the row of grid
                {
                    if (currentrow.Cells["StudentID"].Value != null)
                    {
                        idsToDelete.Add(int.Parse(currentrow.Cells["StudentID"].Value.ToString())); //adding the id of current row in looping in the list
                    }


                }

                try
                {

                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        sqlConnection.Open();
                        foreach (int currentid in idsToDelete) //Deleting all the ids in idsForDelete List
                        {
                            SqlCommand sqlCommand = sqlConnection.CreateCommand();
                            sqlCommand.CommandText = "DELETE FROM tbStudents WHERE StudentID = @ID";
                            sqlCommand.Parameters.AddWithValue("@ID", currentid);
                            sqlCommand.ExecuteNonQuery();
                        }

                        ShowAll();
                        MessageBox.Show("Students Deleted Successfully");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in btnDelete_Click1: {ex.Message}");
                }
            }

            else
            {
                MessageBox.Show("Please select at least one Student to Delete.");
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbStudents", sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    string filePath = "students.csv";
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("StudentID,FirstName,LastName,Age,Grade,Email,DateOfBirth"); // CSV Header

                        while (reader.Read())
                        {
                            //Getting data from Execute Reader query "reader var" currently contains a row currently...
                            //reader gives the value of the column inside square brackets [] and formats it as recquoired to be stored in csv
                            //csv stores tabular data seprated by a delimeter (',' ususallyy) 
                            string csvLine = $"{reader["StudentID"]},{reader["FirstName"]},{reader["LastName"]}," +
                                             $"{reader["Age"]},{reader["Grade"]},{reader["Email"]},{reader["DateOfBirth"]}";
                            writer.WriteLine(csvLine);
                        }
                    }

                    reader.Close();
                    MessageBox.Show("Student records exported successfully to students.csv");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "students.csv";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File students.csv not found.");
                    return;
                }

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        reader.ReadLine(); // Skiping header row

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] data = line.Split(','); //storing the line in an array making it of index 7 by seprating the lines into different strings using Split(',')
                            if (data.Length != 7) continue; // Skip invalid lines i.e those which are incomplete or inseted manually but were wrong and couldnt provide all values or provided extra values

                            int studentID = int.Parse(data[0]);
                            string firstName = data[1];
                            string lastName = data[2];
                            int age = int.Parse(data[3]);
                            string grade = data[4];
                            string email = data[5];
                            DateTime dob = DateTime.Parse(data[6]);

                            // Checking if student already exists
                            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbStudents WHERE StudentID = @ID", sqlConnection);
                            checkCmd.Parameters.AddWithValue("@ID", studentID);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count == 0) // Inserting in case the current student row of file doesnt exists in db to avoid duplication
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

                    MessageBox.Show("Student records imported successfully.");
                    ShowAll(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing from CSV: {ex.Message}");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                IList<Student> lstStudents = new List<Student>();

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbStudents", sqlConnection);
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
                }

                if (lstStudents.Count == 0)
                {
                    MessageBox.Show("No students found to generate a report.");
                    return;
                }

                int totalStudents = lstStudents.Count;
                double averageAge = lstStudents.Average(s => s.Age);

                // Grade-wise student count
                Dictionary<string, int> gradeCounts = lstStudents.GroupBy(s => s.Grade)
                                                                 .ToDictionary(g => g.Key, g => g.Count());

                // Generate Report
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

                MessageBox.Show($"Report generated successfully");
                Process.Start(reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}");
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
