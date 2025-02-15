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
using Classes;
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


        private bool GetInput(string Name=" ",string Age=" ",string Grade=" ")
        {
            if (string.IsNullOrEmpty(Name)&&Name!=" ")
            {
                MessageBox.Show("Name must be Provided");
                return false;
            }
            

            if (!int.TryParse(Age, out int AgeInNumber) && Age != " ")
            {
                MessageBox.Show("Please enter a valid number for Age.");
                return false;
            }
          
            string[] grades = { "A", "B", "C", "D", "F" };
            if (!grades.Contains(Grade.ToUpper()) && Grade != " ")
            {
                MessageBox.Show("Please enter a valid Grade (A,B,C,D,F).");
                return false;
            }

            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (GetInput(tbName.Text,tbAge.Text,tbGrade.Text))
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)";
                    sqlCommand.Parameters.AddWithValue("@Name", tbName.Text);
                    sqlCommand.Parameters.AddWithValue("@Age", int.Parse(tbAge.Text));
                    sqlCommand.Parameters.AddWithValue("@Grade", tbGrade.Text);
                    sqlCommand.ExecuteNonQuery();
                    ShowAll();
                    MessageBox.Show("Student Added Successfully");
                }
            }
              


        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                IList<Student> lstStudents = new List<Student>();

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
                    if (rowsAffected > 0) {
                        ShowAll();
                        MessageBox.Show("All Students with Grade 'F' Deleted Successfully");
                    }
                    else
                        MessageBox.Show("No students found with Grade 'F'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDeleteFailingStudents_Click: {ex.Message}");
            }
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

        private void btnA_Click(object sender, EventArgs e)
        {
            lbGrademsg.Visible = lbGrade.Visible = lbGradeCount.Visible = true;
            Button btn = sender as Button;
            string currentgrade = btn.Text.Substring(btn.Text.Length - 1); // Extract grade from button text
            
            lbGrade.Text = btn.Text +" :";

            try
            {
                IList<Student> lstStudents = new List<Student>();
                grdStudents.DataSource = null;

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    // Query for fetching students with the selected grade
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = "SELECT * FROM Students WHERE Grade = @Grade";
                        sqlCommand.Parameters.AddWithValue("@Grade", currentgrade);

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
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
                        }
                    }

                    // Query for counting students in the selected grade
                    using (SqlCommand countCommand = sqlConnection.CreateCommand())
                    {
                        countCommand.CommandText = "SELECT COUNT(*) FROM Students WHERE Grade = @GradeCount";
                        countCommand.Parameters.AddWithValue("@GradeCount", currentgrade);

                        object result = countCommand.ExecuteScalar();
                        int totalStudents = Convert.ToInt32(result);
                        lbGradeCount.Text = totalStudents.ToString();
                    }

                    grdStudents.DataSource = lstStudents;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnDisplay{currentgrade}Students_Click: {ex.Message}");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count > 0) //Checking if User has selected a row or not
            {
                List<int> idsToDelete = new List<int>(); //Making a list in case user se;ects many students
                foreach (DataGridViewRow currentrow in grdStudents.SelectedRows) // a variable of a built in data type that stored the row of grid
                {
                    if (currentrow.Cells["ID"].Value != null)
                    {
                        idsToDelete.Add(int.Parse(currentrow.Cells["ID"].Value.ToString())); //adding the id of current row in looping in the list
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
                            sqlCommand.CommandText = "DELETE FROM Students WHERE ID = @ID";
                            sqlCommand.Parameters.AddWithValue("ID", currentid);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (grdStudents.SelectedRows.Count == 1) { 
             tbName.Text=grdStudents.CurrentRow.Cells["Name"].Value.ToString();
             tbAge.Text=grdStudents.CurrentRow.Cells["Age"].Value.ToString();
             tbGrade.Text = grdStudents.CurrentRow.Cells["Grade"].Value.ToString();
                btnSubmit.Click -= btnSubmit_Click; // Remove old handler (if previously assigned)
                btnSubmit.Click += btnSubmitUpdate_Click; // Assign new handler
                tbName.BackColor=tbAge.BackColor=tbGrade.BackColor=Color.PaleVioletRed;
                lbUpdate.Visible = true;
                GradeWiseDisplayPannel.Visible = SearchPannel.Visible =false;
                lbGrademsg.Visible = lbGrade.Visible = lbGradeCount.Visible = false;
            }
            else if(grdStudents.SelectedRows.Count>0){
                MessageBox.Show("Only One Student' Inmformation can be Updated at a time");

            }
            else
            {
                MessageBox.Show("Please Select a Student First");

            }
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (GetInput(tbName.Text, tbAge.Text, tbGrade.Text))
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        sqlConnection.Open();

                        SqlCommand sqlCommand = sqlConnection.CreateCommand();



                        sqlCommand.CommandText = "UPDATE Students SET Age = @Age, Name = @Name, Grade = @Grade WHERE ID = @ID";
                        sqlCommand.Parameters.AddWithValue("@Name", tbName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Age", int.Parse(tbAge.Text.Trim()));
                        sqlCommand.Parameters.AddWithValue("@Grade", tbGrade.Text.Trim().ToUpper());
                        sqlCommand.Parameters.AddWithValue("@ID", int.Parse(grdStudents.CurrentRow.Cells["ID"].Value.ToString()));

                        sqlCommand.ExecuteNonQuery();
                        btnSubmit.Click -= btnSubmitUpdate_Click; // Remove old handler (if previously assigned)
                        btnSubmit.Click += btnSubmit_Click; // Assign new handler
                        tbName.BackColor = tbAge.BackColor = tbGrade.BackColor = Color.White;
                        lbUpdate.Visible = false;
                        tbName.Text = tbAge.Text = tbGrade.Text = null;
                        ShowAll();
                        MessageBox.Show("Student Information Updated Successfully");
  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in btnUpdateFinal_Click: {ex.Message}");
                }

            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbUpdate.Visible = GradeWiseDisplayPannel.Visible = SearchPannel.Visible = true;
            lbUpdate.Text = "Enter the name of Student";

        }

        private void btnSearchFinal_Click(object sender, EventArgs e)
        { 
            IList<Student> lststudents = new List<Student>();
            if (GetInput(tbSearchName.Text))
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand=sqlConnection.CreateCommand();
                        sqlCommand.CommandText = "SELECT * FROM Students WHERE Name= @Name";
                        sqlCommand.Parameters.AddWithValue("@Name",tbSearchName.Text.Trim());
                        SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read()) {
                            Student objstudent = new Student()
                            {
                                ID = int.Parse(sqlDataReader["ID"].ToString()),
                                Name = sqlDataReader["Name"].ToString(),
                                Age = int.Parse(sqlDataReader["Age"].ToString()),
                                Grade = sqlDataReader["Grade"].ToString()

                            };
                            lststudents.Add(objstudent);

                        }
                  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in  btnSearchFinal_Click: {ex}");
                }
            }

            if (lststudents.Count==0) {
                MessageBox.Show($"No student found with the given Name !");

            }


            tbSearchName.Text ="";
            grdStudents.DataSource = lststudents;

        }

        private void btnGradeSummary_Click(object sender, EventArgs e)
        {
            GradeWiseDisplayPannel.Visible = true;
        }
    }
}