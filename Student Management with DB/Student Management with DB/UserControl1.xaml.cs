using Student_Management_with_DB;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace WpfStudentManagement
{
    public partial class Authentication : Window
    {
        

        public Authentication()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SMSEntities smsEntities = new SMSEntities();
            string username = TxtUsername.Text;
            string password = TxtPassword.Password;
            var user = smsEntities.tbUsers.FirstOrDefault(u => u.UserName == username && u.Password == password);



             if (user != null)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                 HomePage homePage = new HomePage();
                  homePage.Show();
                this.Close();
            }
             else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
