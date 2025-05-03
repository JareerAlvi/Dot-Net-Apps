using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using System.Globalization;

namespace WpfApp1
{
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SMSEntities smsEntities = new SMSEntities())
            {
                grdStudents.ItemsSource = smsEntities.tbStudents.ToList();
            }
        }
        private bool ValidateStudentInput()
        {
             lbAgeMsg.Content  = lbEmailMsg.Content = string.Empty;

            bool isValid = true;


            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                tbFirstName.BorderBrush = Brushes.Red;  // ✅ Correct
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                tbLastName.BorderBrush = Brushes.Red;  // ✅ Correct

                isValid = false;
            }
            if (!int.TryParse(tbAge.Text, out int age) || age <= 0)
            {
                lbAgeMsg.Content = "Please enter a valid positive number for Age.";
                isValid = false;
            }



            if (!Util.IsValidEmail(tbEmail.Text.Trim()))
            {
                lbEmailMsg.Content = "Please enter a valid Email.";
                isValid = false;
            }


            return isValid;
        }
        private tbStudent CreateStudentFromInput()
        {
            return new tbStudent()
            {
                FirstName = tbFirstName.Text.Trim(),
                LastName = tbLastName.Text.Trim(),
                Age = int.Parse(tbAge.Text),
                Email = tbEmail.Text.Trim(),
                Grade = (cbGrades.SelectedItem as ComboBoxItem).Content.ToString(), //Converting the whole object to just the value...Selected items gets the whole object
                DateOfBirth = dateTimePicker.DisplayDate
            };
        }

        private void PopulateFormFieldsFromSelectedRow(tbStudent selectedStudent)
        {
            if (selectedStudent == null) return;  // ✅ Prevent errors if nothing is selected

            tbFirstName.Text = selectedStudent.FirstName;
            tbLastName.Text = selectedStudent.LastName;
            tbAge.Text = selectedStudent.Age.ToString();
            tbEmail.Text = selectedStudent.Email;

            cbGrades.SelectedItem = cbGrades.Items.Cast<ComboBoxItem>()
                                      .FirstOrDefault(i => i.Content.ToString() == selectedStudent.Grade);

            dateTimePicker.SelectedDate = selectedStudent.DateOfBirth;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateStudentInput())
            {
                return;
            }

            using (SMSEntities smsEntities = new SMSEntities())
            {
                try
                {
                    string email = tbEmail.Text.Trim();

                    // Check if email already exists
                    //The .Any() method checks if at least one record in tbStudents matches the condition.
                    bool emailExists = smsEntities.tbStudents.Any(s => s.Email == email);
                    if (emailExists)
                    {
                        MessageBox.Show("This email is already registered. Please use a different email.", "Duplicate Email", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    var newStudent = CreateStudentFromInput();

                    smsEntities.tbStudents.Add(newStudent);
                    smsEntities.SaveChanges();

                    tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                    cbGrades.SelectedItem = "A";
                    dateTimePicker.DisplayDate = DateTime.Now;

                    // Refresh the DataGridView
                    LoadStudents();

                    MessageBox.Show("Student has been added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            btnAddStudent.Background = (Brush)new BrushConverter().ConvertFrom("#FF0000");
            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
            btnAddStudent.Click -= btnCancel_Click;
            btnAddStudent.Click += btnAddStudent_Click;
            btnUpdateStudent.Click -= btnSubmitUpdate_Click;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            btnAddStudent.Content = "Add Student";
            btnAddStudent.Background = (Brush)new BrushConverter().ConvertFrom("#FF27AE60");
        }
        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {
            if (grdStudents.SelectedItems.Count == 1)  // ✅ WPF: Use SelectedItems.Count
            {
                tbStudent selectedStudent = (tbStudent)grdStudents.SelectedItem;  // ✅ Get selected student

                if (selectedStudent != null)
                {
                    PopulateFormFieldsFromSelectedRow(selectedStudent);  // ✅ Update form with student data
                    btnUpdateStudent.Click -= btnUpdateStudent_Click;
                    btnUpdateStudent.Click += btnSubmitUpdate_Click;
                    btnAddStudent.Click -= btnAddStudent_Click;
                    btnAddStudent.Click += btnCancel_Click;
                    btnAddStudent.Content = "Cancel";
                    btnAddStudent.Background = (Brush)new BrushConverter().ConvertFrom("#FF0000");
                    grdStudents.SelectedItem = null; // unclicking to avoid complications 

                    return;
                }
            }
            else if (grdStudents.SelectedItems.Count > 1)
            {
                MessageBox.Show("Only one student's information can be updated at a time.",
                                "Update Restriction",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                grdStudents.SelectedItem = null; // unclicking to avoid complications 

            }
            else
            {
                MessageBox.Show("Please select a student first.",
                                "No Selection",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }

        }
        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentInput())
            {
                return;
            }

            using (SMSEntities smsEntities = new SMSEntities())
            {
                tbStudent selectedStudent=(tbStudent)grdStudents.SelectedItem;
                int studentID = int.Parse(selectedStudent.StudentID.ToString());

                var existingStudent = smsEntities.tbStudents.FirstOrDefault(s => s.StudentID == studentID); //existingStudent is now a reference to that database record (not a copy).
                bool emailExists = smsEntities.tbStudents.Any(s => s.Email == tbEmail.Text.Trim() && s.StudentID != studentID);
                if (emailExists)
                {
                    MessageBox.Show("This email is already registered. Please use a different email.", "Duplicate Email", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                existingStudent.FirstName = tbFirstName.Text;
                existingStudent.LastName = tbLastName.Text;
                existingStudent.Age = int.Parse(tbAge.Text);
                existingStudent.Email = tbEmail.Text;
                existingStudent.Grade = (cbGrades.SelectedItem as ComboBoxItem).Content.ToString();
                existingStudent.DateOfBirth = dateTimePicker.SelectedDate.Value;

                smsEntities.SaveChanges();

                tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                cbGrades.SelectedItem = "A";
                dateTimePicker.SelectedDate = DateTime.Now;

                btnUpdateStudent.Click -= btnSubmitUpdate_Click;
                btnUpdateStudent.Click += btnUpdateStudent_Click;
                btnAddStudent.Click -= btnCancel_Click;
                btnAddStudent.Click += btnAddStudent_Click;
                btnAddStudent.Content = "Add Student";
                btnAddStudent.Background = (Brush)new BrushConverter().ConvertFrom("#FF27AE60");

                // Refresh the DataGridView
                LoadStudents();

                MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (SMSEntities smsEntities = new SMSEntities())
            {
                string searchValue = tbSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchValue))
                {
                    grdStudents.ItemsSource = smsEntities.tbStudents.ToList();
                    return;
                }
                var students = smsEntities.tbStudents.Where(s =>
                s.FirstName.Contains(searchValue) ||
                s.LastName.Contains(searchValue) ||
                s.Email.Contains(searchValue) ||
                s.Grade.Contains(searchValue) ||
                s.Age.ToString().Contains(searchValue)
                );
                grdStudents.ItemsSource = students.ToList();
            }
        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (grdStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one Student to Delete.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            List<int> lstIdsToDelete = new List<int>();
            foreach (tbStudent currentrow in grdStudents.SelectedItems)
            {
                lstIdsToDelete.Add((int)currentrow.StudentID);
            }

            // Confirmation message box
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete the selected student(s)?",
                                           "Confirm Deletion",
                                           MessageBoxButton.YesNo,  // ✅ WPF equivalent of Yes/No buttons
                                           MessageBoxImage.Warning);  // ✅ WPF equivalent of Warning icon

            if (result != MessageBoxResult.Yes)  // ✅ WPF equivalent of DialogResult.Yes
            {
                return;
            }

            using (SMSEntities smsEntities = new SMSEntities())
            {
                var studentsToDelete = smsEntities.tbStudents
                       .Where(s => lstIdsToDelete.Contains(s.StudentID))
                       .ToList();


                smsEntities.tbStudents.RemoveRange(studentsToDelete);  //.RemoveRange() DELETES Multiples records at once
                smsEntities.SaveChanges();
                LoadStudents();
                MessageBox.Show("Students Deleted Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fdExportCSV = new SaveFileDialog();
                if (fdExportCSV.ShowDialog() != true) // User selects a file
                {
                    return;
                }
                    string filePath = fdExportCSV.FileName;

                    using (SMSEntities smsEntities = new SMSEntities()) // Replace with your actual DbContext class
                    {
                        var students = smsEntities.tbStudents
                            .Select(s => new
                            {
                                s.FirstName,
                                s.LastName,
                                s.Age,
                                s.Grade,
                                s.Email,
                                s.DateOfBirth // Fetch DateOfBirth as DateTime
                            })
                            .ToList(); // Execute query first

                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            // Write CSV Header (excluding StudentID)
                            writer.WriteLine("FirstName,LastName,Age,Grade,Email,DateOfBirth");

                            foreach (var student in students)
                            {
                                // Convert DateOfBirth to string AFTER retrieving from DB
                                string dobFormatted = student.DateOfBirth.ToString("yyyy-MM-dd");

                                string csvLine = $"{student.FirstName},{student.LastName}," +
                                                 $"{student.Age},{student.Grade},{student.Email},{dobFormatted}";

                                writer.WriteLine(csvLine);
                            }
                        }

                        MessageBox.Show($"Student records exported successfully to {filePath}",
                                        "Export Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fdImportCSV = new OpenFileDialog();

                if (fdImportCSV.ShowDialog() != true)
                {
                    return;
                }
                    string filePath = fdImportCSV.FileName;

                    using (var context = new SMSEntities()) // Replace with your actual DbContext class
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            reader.ReadLine(); // Skip header
                            int lineNumber = 1; // Track line numbers for error messages

                            while ((line = reader.ReadLine()) != null)
                            {
                                lineNumber++;
                                string[] data = line.Split(',');

                                if (data.Length != 6)
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Incorrect number of fields.",
                                                    "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    continue;
                                }

                                string firstName = data[0].Trim();
                                string lastName = data[1].Trim();

                                // Validate Age
                                if (!int.TryParse(data[2].Trim(), out int age) || age <= 0)
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid age value ({data[2]}).",
                                                    "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    continue;
                                }

                                string grade = data[3].Trim();
                                string email = data[4].Trim();

                                if (!Util.IsValidEmail(email))
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid email format ({email}).",
                                                    "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    continue;
                                }

                                // Validate and parse DateOfBirth correctly
                                if (!DateTime.TryParseExact(data[5].Trim(), "yyyy-MM-dd",
                                                            CultureInfo.InvariantCulture,
                                                            DateTimeStyles.None, out DateTime dob))
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid Date of Birth format ({data[5]}). Expected format: yyyy-MM-dd",
                                                    "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    continue;
                                }

                                // Check if student exists (by Email)
                                bool studentExists = context.tbStudents.Any(s => s.Email == email);

                                if (!studentExists)
                                {
                                    // Convert SMSStudent to tbStudent
                                    var student = new tbStudent
                                    {
                                        FirstName = firstName,
                                        LastName = lastName,
                                        Age = age,
                                        Grade = grade,
                                        Email = email,
                                        DateOfBirth = dob
                                    };

                                    context.tbStudents.Add(student); // Now it's in the correct format
                                }

                            }

                            context.SaveChanges(); // Save all valid students
                        }

                        MessageBox.Show("Student records imported successfully.",
                                        "Import Success", MessageBoxButton.OK, MessageBoxImage.Information);

                        grdStudents.ItemsSource = null; // Refresh UI
                        grdStudents.ItemsSource = context.tbStudents.ToList();
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing from CSV: {ex.Message}", "Import Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void tbFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbFirstName.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#FF2980B9");

        }

        private void tbLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbLastName.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#FF2980B9");
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fdExportCSV = new SaveFileDialog();
            if (fdExportCSV.ShowDialog() != true)  // ✅ WPF uses `true` instead of `DialogResult.OK`
            {
                return;
            }
            using (SMSEntities smsEntities = new SMSEntities()) { 
            
              IList<tbStudent> lstStudents = smsEntities.tbStudents.ToList();
            fdExportCSV.Filter = "All files (*.*)|*.*";
            fdExportCSV.FileName = "report.txt"; //Default Name
            fdExportCSV.Title = "Report";

            try
            {
                if (lstStudents.Count == 0)
                {
                    MessageBox.Show("No students found to generate a report.", "No Data", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                int totalStudents = lstStudents.Count;
                double averageAge = lstStudents.Average(s => s.Age);

                Dictionary<string, int> gradeCounts = lstStudents.GroupBy(s => s.Grade)
                                                                 .ToDictionary(g => g.Key, g => g.Count());

                StringBuilder report = new StringBuilder();
                report.AppendLine("Student Report");
                report.AppendLine("----------------------------");
                report.AppendLine($"Total Students: {totalStudents}");
                report.AppendLine($"Average Age: {averageAge:F2}");
                report.AppendLine("\nGrade-wise Student Count:");

                foreach (var grade in gradeCounts)
                {
                    report.AppendLine($"Grade {grade.Key}: {grade.Value} students");
                }

                string reportPath = fdExportCSV.FileName;
                File.WriteAllText(reportPath, report.ToString());

                MessageBox.Show($"Report generated successfully", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Information);
                Process.Start(reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Report Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
            }

              
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cbSort.SelectedItem == null || cbSortOrder.SelectedItem == null)
            {
                MessageBox.Show("Please select sorting criteria and order.", "Sorting Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            string selectedCriteria = (cbSort.SelectedItem as ComboBoxItem)?.Content.ToString();  
            string sortOrder = (cbSortOrder.SelectedItem as ComboBoxItem)?.Content.ToString();  


            using (SMSEntities context = new SMSEntities()) 
            {
                IQueryable<tbStudent> query = context.tbStudents; // Start with base query

                switch (selectedCriteria)
                {
                    case "FirstName":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.FirstName) : query.OrderBy(s => s.FirstName);
                        break;
                    case "LastName":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.LastName) : query.OrderBy(s => s.LastName);
                        break;
                    case "Grade":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.Grade) : query.OrderBy(s => s.Grade);
                        break;
                    case "Age":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.Age) : query.OrderBy(s => s.Age);
                        break;
                    case "Email":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.Email) : query.OrderBy(s => s.Email);
                        break;
                    case "DateOfBirth":
                        query = (sortOrder == "Descending") ? query.OrderByDescending(s => s.DateOfBirth) : query.OrderBy(s => s.DateOfBirth);
                        break;
                    default:
                        MessageBox.Show("Invalid sorting option selected.", "Sorting Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                }

                grdStudents.ItemsSource = query.ToList(); // Fetch sorted data
            }
        }

    
    }
}
