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

namespace Student_Management_with_DB
{
    public partial class Form1 : Form
    {
        string ConnectionString= "data source=ADMIN-1;initial catalog=School;Integrated Security=True;trustservercertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        private string Name;
        private int Age;
        private string Grade;
      
          private void GetInput()
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("Name Cannot Be Null");
                return;
            }
            Name = tbName.Text.Trim();

            if (!int.TryParse(tbAge.Text.Trim(), out Age))
            {
                MessageBox.Show("Please enter a valid number for Age.");
                return;
            }
            string[] grades = { "A","B","C","D","F" };
            if (grades.Contains(tbGrade.Text.Trim().ToUpper())) {
                Grade = tbGrade.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please enter a valid Grade (A,B,C,D,F).");
                return;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            GetInput();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                //Checking if ID is less than 5 or Not
                string checkQuery = "SELECT MAX(ID) FROM Students";
                SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                object result = checkCommand.ExecuteScalar();
                int.TryParse(result.ToString(), out int id);
                if (id == 5)
                {
                    MessageBox.Show("Students Limit Reached! Cannot Add More.");
                    return;
                }
                
                //Adding the Student 
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)";
                sqlCommand.Parameters.AddWithValue("@Name",Name);
                sqlCommand.Parameters.AddWithValue("@Age", Age);
                sqlCommand.Parameters.AddWithValue("@Grade", Grade);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");
                
            }



        }
        private IList<Student> lstStudents = new List<Student>();

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Students";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Student objStudent = new Student()
                    {
                        ID= int.Parse(sqlDataReader["ID"].ToString()),
                        Name = sqlDataReader["Name"].ToString(),
                        Age = int.Parse(sqlDataReader["Age"].ToString()),
                        Grade = sqlDataReader["Grade"].ToString()
                    };


                    lstStudents.Add(objStudent);
                }
                grdStudents.DataSource= lstStudents;


            }
        }
        public class Student
        {
            public int ID {  get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }

        private void btnDisplayAStudents_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Students WHERE Grade = 'A'";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Student objStudent = new Student()
                    {
                        ID = int.Parse(sqlDataReader["ID"].ToString()),
                        Name = sqlDataReader["Name"].ToString(),
                        Age = int.Parse(sqlDataReader["Age"].ToString()),
                        Grade = sqlDataReader["Grade"].ToString()
                    };

                    lstStudents.Add(objStudent);
                }
                grdStudents.DataSource = null;
                grdStudents.DataSource = lstStudents;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDisplayAll.Visible = false;
            btnUpdate.Visible = false;
            btnSubmit.Visible = false;
            btnDisplayAStudents.Visible = false;
            btnUpdateAge.Visible = true;
            btnUpdateGrade.Visible = true;  
        }

        private void btnUpdateAge_Click(object sender, EventArgs e)
        {
            btnUpdateGrade.Visible=false;
            label1.Text = "ID";
            label3.Visible = false;
            tbGrade.Visible = false;
            btnUpdateAge.Visible=false;
            AgeUpdatebtn.Visible = true;
        }

        private void AgeUpdatebtn_Click(object sender, EventArgs e)
        {
          
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "UPDATE Students SET Age = @Age WHERE ID = @ID";
                sqlCommand.Parameters.AddWithValue("@Age", int.Parse(tbAge.Text.Trim()));
                sqlCommand.Parameters.AddWithValue("@ID", int.Parse(tbName.Text.Trim()));

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Student Age Updated Successfully");
                else
                    MessageBox.Show("No student found with the given ID");
            }
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            btnUpdateGrade.Visible = false;
            label2.Text = "Grade";
            label3.Visible = false;
            tbGrade.Visible = false;
            btnUpdateAge.Visible = false;
            GradeUpdatebtn.Visible = true;
        }

        private void GradeUpdatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "UPDATE Students SET Grade = @Grade WHERE Name = @Name";
                sqlCommand.Parameters.AddWithValue("@Grade", tbAge.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Name", tbName.Text.Trim());

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Student Grade Updated Successfully");
                else
                    MessageBox.Show("No student found with the given Name");
            }
        }

        private void btnDeleteFailingStudents_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "DELETE FROM Students WHERE Grade = 'F'";

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("All Students with Grade 'F' Deleted Successfully");
                else
                    MessageBox.Show("No students found with Grade 'F'");
            }
            grdStudents.DataSource = null;
        }
    }

}
