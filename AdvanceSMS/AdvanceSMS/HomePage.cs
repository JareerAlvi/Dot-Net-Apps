using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Classes;
namespace Student_Management_with_DB
{
    public partial class HomePage : Form
    {
        string ConnectionString = "data source=ADMIN-1;initial catalog=SMS;Integrated Security=True;trustservercertificate=True";

        public HomePage()
        {
            InitializeComponent();
            ShowAll();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateStudentInput()
        {
            
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lbFNameMsg.Text = "First Name must be provided.";
                return false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbLNameMsg.Text = "Last Name must be provided.";
                return false;
            }

            // Validate Age (must be a positive integer)
            if (int.Parse(tbAge.Text.ToString()) <= 0)
            {
                lbAgeMsg.Text = "Please enter a valid positive number for Age.";
                return false;
            }

            // Validate Grade (Must be A, B, C, D, or F)
            string[] validGrades = { "A", "B", "C", "D", "F" };
            if (!validGrades.Contains(tbGrade.Text.ToUpper()))
            {
                lbGradeMsg.Text = "Please enter a valid Grade (A, B, C, D, F).";
                return false;
            }

            // Validate Email (Simple format check)
            if (!IsValidEmail(tbEmail.Text))
            {
                lbEmailMsg.Text = "Please enter a valid Email.";
                return false;
            }

            // Validate Date of Birth (Should not be a future date)
            if (DateTime.Parse(dateTimePicker.Text) > DateTime.Now)
            {
                lbDOBMsg.Text = "Date of Birth cannot be in the future.";
                return false;
            }

            return true;
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
                    sqlConnection.Open();

                    ShowAll();

                }
            }



        }
    }
}
