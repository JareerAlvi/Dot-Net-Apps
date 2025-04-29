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
using System.Windows.Threading;

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




        public class ContactDTO //Added cuz i had problem accessing name and Contact from List
        {
            public string ContactNumber { get; set; }
            public string Name { get; set; }
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
          (c, u) => new ContactDTO
          {
              ContactNumber = u.ContactNumber,
              Name = u.Name
          })
      .ToList();

                    ContactList.ItemsSource = contacts;
                    ContactList.DisplayMemberPath = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading contacts: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
                var selectedUser = ContactList.SelectedItem as ContactDTO;
                if (selectedUser == null)
                {
                    MessageBox.Show("Please select a valid contact.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                string recieverContact = selectedUser.ContactNumber;
                ChatTitle.Text = selectedUser.Name;


                MessagesPanel.Children.Clear(); // clearing msgs from another chat
                try {
                    using (Chatting_AppEntities context = new Chatting_AppEntities())
                    {
                        var encryptedMessages = context.tbMessages
             .Where(m =>
        (m.SenderContact == Shared.loggedInContactNumber && m.ReceiverContact == recieverContact) ||
        (m.SenderContact == recieverContact && m.ReceiverContact == Shared.loggedInContactNumber)
    )
    .OrderBy(m => m.SentAt)
    .ToList();
                        // This runs the SQL and loads into memory

                        var decryptedMessages = encryptedMessages
                            .Select(m => new {
                                m.MessageId,
                                m.SenderContact,
                                m.ReceiverContact,
                                Content = AES.Decrypt(m.Content, AES.key),  // Now it's OK — in memory
                                m.SentAt
                            }).ToList();



                        // Clear old messages
                        MessagesPanel.Children.Clear();

                        foreach (var message in decryptedMessages)
                        {
                            bool isSentByMe = message.SenderContact == Shared.loggedInContactNumber;
                            AddMessageBubble(message.Content, isSentByMe);
                        }

                        ChatArea.Visibility = Visibility.Visible;
                        btnSend.Visibility = Visibility.Visible;
                        MessageBox2.Visibility = Visibility.Visible;

                    }

                }
                catch (Exception ex){
                    MessageBox.Show("An error occurred ContactList_SelectionChanged : " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
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
            string myMessage = MessageBox2.Text.Trim();
            var selectedUser = ContactList.SelectedItem as ContactDTO;
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a valid contact.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string recieverContact = selectedUser.ContactNumber;


            if (!string.IsNullOrEmpty(myMessage))
            {
                try
                {
                    using (Chatting_AppEntities context = new Chatting_AppEntities())
                    {
                        tbMessage message = new tbMessage();
                        message.SenderContact = Shared.loggedInContactNumber;

                        if (ContactList.SelectedItem == null)
                        {
                            MessageBox.Show("Please select a contact to send the message.", "No Contact", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }

                        message.ReceiverContact = recieverContact; // ✅ Correct property now

                        message.Content = AES.Encrypt(myMessage, AES.key);
                        message.SentAt = DateTime.Now;

                        context.tbMessages.Add(message);
                        context.SaveChanges();
                    }

                    AddMessageBubble(myMessage, true); // Sent by logged-in user
                    MessageBox2.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred btnSend_Click: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}
