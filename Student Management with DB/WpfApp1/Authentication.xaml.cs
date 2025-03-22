using System.Runtime.Remoting.Contexts;
using System.Windows;
using System.Linq;
namespace WpfApp1
{
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            using (SMSEntities userEntity = new SMSEntities())
            {

                string username = txtUsername.Text;
                string password = txtPassword.Password;
                bool userExists = userEntity.tbUsers.Any(user => user.UserName == username && user.Password == password);

                if (userExists)
                {
                    HomePage home = new HomePage();
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}
