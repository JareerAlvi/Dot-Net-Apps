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
using System.Windows.Shapes;

namespace Chatting_App
{
    /// <summary>
    /// Interaction logic for NewContact.xaml
    /// </summary>
    public partial class NewContact : Window
    {
        public NewContact()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {

            lbWarning.Text = string.Empty;
            txtContactNumber.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2980B9"));
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                txtContactNumber.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF4747"));
                isValid = false;
            }

            return isValid;
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



        private void btn_Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateInput())
            {
                lbWarning.Text = "Invalid Contact No.";
                return;
            }
            try
            {
                using (Chatting_AppEntities contactEntity = new Chatting_AppEntities())
                {
                    string newContact = txtContactNumber.Text;

                    // Check if the contact exists in the users table
                    bool existsInUsers = contactEntity.tbUsers.Any(u => u.ContactNumber == newContact);

                    // Check if the contact already exists in the user's contacts list
                    bool existsInContacts = contactEntity.tbContacts
                        .Any(c => c.UserContactNumber == Shared.loggedInContactNumber && c.ContactNumber == newContact);

                    // If contact doesn't exist in the users table
                    if (!existsInUsers)
                    {
                        lbWarning.Text = "Contact Number Does Not Exist";
                        return;
                    }

                    // If the contact is already in the user's contact list
                    if (existsInContacts)
                    {
                        lbWarning.Text = "Contact Already in List";
                        return;
                    }

                    // Create the contact relationship in both directions
                    var contact = new tbContact
                    {
                        UserContactNumber = Shared.loggedInContactNumber,
                        ContactNumber = newContact,
                        AddedOn = DateTime.Now
                    };

                    var currentContactForNewOne = new tbContact
                    {
                        UserContactNumber = newContact,
                        ContactNumber = Shared.loggedInContactNumber,
                        AddedOn = DateTime.Now
                    };

                    // Add both contacts to the database
                    contactEntity.tbContacts.Add(contact);
                    contactEntity.tbContacts.Add(currentContactForNewOne);
                    contactEntity.SaveChanges();

                    // Close the window after adding the contact
                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contacts: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
