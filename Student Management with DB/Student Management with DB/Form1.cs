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

namespace Student_Management_with_DB
{
    public partial class Form1 : Form
    {
        string ConnectionString = "data source=ADMIN-1;initial catalog=School;Integrated Security=True;trustservercertificate=True";
        public Form1()
        {
            InitializeComponent();
            ShowAll();
        }
        private string Name;
        private int Age;
        private string Grade;

        private bool GetInput()
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("Name Cannot Be Null");
                return false;
            }
            Name = tbName.Text.Trim();

            if (!int.TryParse(tbAge.Text.Trim(), out Age))
            {
                MessageBox.Show("Please enter a valid number for Age.");
                return false;
            }
            string[] grades = { "A", "B", "C", "D", "F" };
            if (grades.Contains(tbGrade.Text.Trim().ToUpper()))
            {
                Grade = tbGrade.Text.Trim();
            }
            else
            {
                MessageBox.Show("Please enter a valid Grade (A,B,C,D,F).");
                return false;
            }
            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (GetInput())
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    string checkQuery = "SELECT MAX(ID) FROM Students";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                    object result = checkCommand.ExecuteScalar();


                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)";
                    sqlCommand.Parameters.AddWithValue("@Name", Name);
                    sqlCommand.Parameters.AddWithValue("@Age", Age);
                    sqlCommand.Parameters.AddWithValue("@Grade", Grade);
                    sqlCommand.ExecuteNonQuery();
                    ShowAll();
                    MessageBox.Show("Student Added Successfully");
                }
            }
              


        }

        private IList<Student> lstStudents = new List<Student>();

        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }

        private void btnDisplayAStudents_Click(object sender, EventArgs e)
        {
            GradeWiseDisplayPannel.Visible = true;
        }


        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                lstStudents = new List<Student>();
                grdStudents.DataSource = null;

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
                            ID = int.Parse(sqlDataReader["ID"].ToString()),
                            Name = sqlDataReader["Name"].ToString(),
                            Age = int.Parse(sqlDataReader["Age"].ToString()),
                            Grade = sqlDataReader["Grade"].ToString()
                        };

                        lstStudents.Add(objStudent);
                    }

                    grdStudents.DataSource = lstStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDisplayAll_Click: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDisplayAll.Visible = false;
            btnUpdate.Visible = false;
            btnSubmit.Visible = false;
            btnDisplayByGrade.Visible = false;
            btnIDDelete.Visible = false;
            btnDeleteFailingStudents.Visible = false;
            UpdatePanel.Visible = true;
            ShowAll();

        }

        private void btnDeleteFailingStudents_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDeleteFailingStudents_Click: {ex.Message}");
            }
        }

        private void btnIDDelete_Click(object sender, EventArgs e)
        {
            ShowAll();
            btnDisplayAll.Visible = false;
            btnUpdate.Visible = false;
            btnSubmit.Visible = false;
            btnDisplayByGrade.Visible = false;

            btnDeleteFailingStudents.Visible = false;
            btnIDDelete.Visible = false;
            DeletePanel.Visible = true;
        }



        private void btnUpdateFinal_Click(object sender, EventArgs e)
        {
            
            grdStudents.DataSource=lstStudents;
            if (string.IsNullOrWhiteSpace(tbNameUpdate.Text) || string.IsNullOrEmpty(tbAgeUpdate.Text) || string.IsNullOrEmpty(tbGradeUpdate.Text))
            {
                MessageBox.Show("No Field Cant be Empty");
                return;
            }
            if (!int.TryParse(tbAgeUpdate.Text.Trim(), out int age))
            {
                MessageBox.Show("Please Enter A Valid Number For Age");
                return;
            }

            string[] grades = { "A", "B", "C", "D", "F" };
            if (!grades.Contains(tbGradeUpdate.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Please Enter A Valid Grade (A, B, C, D, F).");
                return;
            }

            if (!int.TryParse(tbIDForUpdate.Text.Trim(), out int studentID))
            {
                MessageBox.Show("Please Enter A Valid ID.");
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();



                    sqlCommand.CommandText = "UPDATE Students SET Age = @Age, Name = @Name, Grade = @Grade WHERE ID = @ID";
                    sqlCommand.Parameters.AddWithValue("@Name", tbNameUpdate.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Age", age);
                    sqlCommand.Parameters.AddWithValue("@Grade", tbGradeUpdate.Text.Trim().ToUpper());
                    sqlCommand.Parameters.AddWithValue("@ID", studentID);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        ShowAll();
                        MessageBox.Show("Student Information Updated Successfully");
                    }

                    else
                        MessageBox.Show("No Student Found With The Given ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnUpdateFinal_Click: {ex.Message}");
            }

        }

        private void ShowAll()
        {
            try
            {
                lstStudents = new List<Student>();
                grdStudents.DataSource = null;

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
                            ID = int.Parse(sqlDataReader["ID"].ToString()),
                            Name = sqlDataReader["Name"].ToString(),
                            Age = int.Parse(sqlDataReader["Age"].ToString()),
                            Grade = sqlDataReader["Grade"].ToString()
                        };

                        lstStudents.Add(objStudent);
                    }

                    grdStudents.DataSource = lstStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDisplayAll_Click: {ex.Message}");
            }
        }

        private void btnDeleteFinal_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "DELETE FROM Students WHERE ID = @ID";
                    sqlCommand.Parameters.AddWithValue("@ID", int.Parse(tbIDforDelete.Text.Trim()));

                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ShowAll();
                        MessageBox.Show("Student Deleted Successfully");
                    }
                    else
                        MessageBox.Show("No student found with the given ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDelFinal_Click: {ex.Message}");
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string grade = btn.Text;
            try
            {
                lstStudents = new List<Student>();
                grdStudents.DataSource = null;

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "SELECT * FROM Students WHERE Grade = @Grade";
                    sqlCommand.Parameters.AddWithValue("@Grade", grade);
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

                    grdStudents.DataSource = lstStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDisplayAStudents_Click: {ex.Message}");
            }
        }
    }
}