using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
            ContactList.Items.Clear(); //To initially load clearing it
            LoadContacts();
        }
        private void LoadContacts()
        {
            try
            {
                using (Chatting_AppEntities chatting_AppEntities = new Chatting_AppEntities())
                {
                    var contacts = chatting_AppEntities.tbContacts
                        .Where(c => c.UserContactNumber == Shared.loggedInContactNumber)
                        .Join(chatting_AppEntities.tbUsers,
                            c => c.ContactNumber,
                            u => u.ContactNumber,
                            (c, u) => new
                            {
                                u.ContactNumber,
                                u.Name
                            })
                        .ToList();

                    // Directly assign the new collection to the ItemsSource without clearing first
                    ContactList.ItemsSource = null;  // This detaches the current ItemsSource
                    ContactList.ItemsSource = contacts;  // Reassign the new data
                    ContactList.DisplayMemberPath = "Name"; // Display the Name property in the ListBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Text = ex.Message;  // Ensure that MessageBox is the correct control
            }
        }
        private void AddMessageBubble(string messageText, bool isSentByMe)
        {
            Border bubble = new Border
            {
                Background = isSentByMe ? new SolidColorBrush(Color.FromRgb(44, 80, 79)) : new SolidColorBrush(Color.FromRgb(70, 70, 70)),
                CornerRadius = new CornerRadius(10),
                Padding = new Thickness(10),
                Margin = new Thickness(5),
                MaxWidth = 250,
                HorizontalAlignment = isSentByMe ? HorizontalAlignment.Right : HorizontalAlignment.Left
            };

            TextBlock message = new TextBlock
            {
                Text = messageText,
                Foreground = Brushes.White,
                TextWrapping = TextWrapping.Wrap
            };

            bubble.Child = message;
            MessagesPanel.Children.Add(bubble);
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
        private void ContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContactList.SelectedItem != null)
            {
                dynamic selectedContact = ContactList.SelectedItem;
                ChatTitle.Text = selectedContact.Name; // Set the selected contact name
                ChatArea.Visibility= MessageBox.Visibility=btnSend.Visibility=Visibility.Visible;
                // Optionally: Clear old messages when switching contacts
               // ChatMessagesPanel.Children.Clear();
            }
        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            
                NewContact window = new NewContact();
                Console.WriteLine(window.GetType());  // This will print the type of 'window' to the Output window
                window.ShowDialog();
                LoadContacts();




        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string myMessage = MessageBox.Text.Trim();
            if (!string.IsNullOrEmpty(myMessage))
            {
                AddMessageBubble(myMessage, true);
                MessageBox.Text = "";
            }

        }
    }
}
