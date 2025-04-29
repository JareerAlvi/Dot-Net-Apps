using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;

namespace IMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IMSEntities IMS = new IMSEntities();

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            using (IMSEntities context = new IMSEntities())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {
                    // Optional: Fetch tenant if needed
                    var tenant = context.Tenants.FirstOrDefault(t => t.TenantID == user.TenantID);

                    MessageBox.Show("Login successful!");

                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
                
            }
        }
    }
}
