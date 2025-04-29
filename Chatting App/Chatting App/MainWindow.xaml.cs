using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Chatting_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class    BaseWindow : Window
    {
        public BaseWindow()
        {
            InitializeComponent();
            
        }
         
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private bool ValidateInput()
        {

            lbWarning.Text = string.Empty;
            txtPassword.BorderBrush=txtContactNumber.BorderBrush= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2980B9"));
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                txtContactNumber.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF4747")); 
                isValid = false; 
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                txtPassword.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF4747"));
                
                isValid = false;
            }
            return isValid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Chatting_AppEntities userEntity = new Chatting_AppEntities())
            {

                if (!ValidateInput())
                {
                    return;
                }
                
                string contactNumber = txtContactNumber.Text;
                string password = AES.Encrypt(txtPassword.Password,AES.key);
                bool userExists = userEntity.tbUsers.Any(user => user.ContactNumber == contactNumber && user.Password == password);

                if (!userExists)
                {
                    lbWarning.Text += "Incorrect Password or Contact No.";
                    lbWarning.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF4747"));
                    return;
                }
                else
                {

                   Shared.loggedInContactNumber = txtContactNumber.Text;
                    HomePage home = new HomePage();
                    home.Show();
                    this.Close();
                }
            }

        }

        private void txtContactNumber_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is an alphabet letter (A-Z, a-z)
            if ((e.Key >= Key.A && e.Key <= Key.Z) ||
                (e.Key >= Key.Oem1 && e.Key <= Key.Oem102)) // Includes some special chars
            {
                SystemSounds.Beep.Play(); // Plays default system beep

                // Alternative: Console.Beep(frequency, duration)
                // Console.Beep(800, 100); // Higher pitch beep
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            btnLogin.Visibility = btnSignUp.Visibility = Visibility.Hidden;
            lbHeading.Text = "SignUp";
            txtContactNumber.Text = txtPassword.Password= lbWarning.Text =  string.Empty;
            txtContactNumber.BorderBrush=txtPassword.BorderBrush= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2980B9"));
            
            lb_Name.Visibility=txtName.Visibility = btn_Confirm.Visibility = Visibility.Visible;

        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput())
            {
                if (txtName.Text == string.Empty)
                {
                    txtName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF4747"));

                    return;

                }
                return; 
            
            }

            try
            {
                using (Chatting_AppEntities userEntity = new Chatting_AppEntities())
                {
                    

                    string contactNumber = txtContactNumber.Text.Trim();
                    string password = AES.Encrypt(txtPassword.Password, AES.key);
                    string Name= txtName.Text.Trim();
                    bool exists = userEntity.tbUsers.Any(u => u.ContactNumber == contactNumber);

                    if (exists)
                    {
                        lbWarning.Text = "Contact Number Already Exists";
                        return;
                    }

                    var user = new tbUser
                    {
                        ContactNumber = contactNumber,
                        Password = password,
                        Name = Name
                    };

                    userEntity.tbUsers.Add(user);
                    userEntity.SaveChanges();

                    btnLogin.Visibility = btnSignUp.Visibility = Visibility.Visible;
                    
                    lbHeading.Text = "Login";
                    txtContactNumber.Text = txtPassword.Password = string.Empty;
                    txtContactNumber.BorderBrush = txtPassword.BorderBrush = txtName.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2980B9"));
                    lb_Name.Visibility = txtName.Visibility = btn_Confirm.Visibility = Visibility.Hidden;
                    MessageBox.Show("User Registered Successfully!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



    }
}
