using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_with_DB
{
    public partial class SMS_Authentication : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public SMS_Authentication()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text.Trim();
            string Password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(Name))
            {
                lbNameMsg.ForeColor = Color.Red;
                lbNameMsg.Text = "Name must be provided.";
                lbNameMsg.Visible = true; // Show the error message
                lbPassMsg.Visible = false; // Hide the password error message
                return;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                lbPassMsg.ForeColor = Color.Red;
                lbPassMsg.Text = "Password must be provided.";
                lbPassMsg.Visible = true; // Show the error message
                lbNameMsg.Visible = false; // Hide the name error message
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM tbUsers WHERE UserName= @Name AND Password=@Password";
                    sqlCommand.Parameters.AddWithValue("@Name", Name);
                    sqlCommand.Parameters.AddWithValue("@Password", Password);

                    int userExists = (int)sqlCommand.ExecuteScalar();
                    if (userExists > 0)
                    {
                        HomePage homePage = new HomePage();
                        homePage.Show();
                        this.Hide();
                    }
                    else
                    {
                        lbPassMsg.Text = "Invalid username or password.";
                        lbPassMsg.ForeColor = Color.Red;
                        lbNameMsg.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in btnLogin_Click: {ex}");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0'; //Assining NULL
        }

        private void btnShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
            tbPassword.Focus(); //Taking the cursor back to tbPassword fr a better user experience
        }
    }
}
