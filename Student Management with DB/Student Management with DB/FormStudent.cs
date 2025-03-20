using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Student_Management_with_DB
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            string[] validGrades = { "A", "B", "C", "D", "F" };
            cbSort.DataSource = new List<string> { "FirstName", "LastName", "Grade", "Age", "Email", "DateOfBirth" };
            cbSortOrder.DataSource = new List<string> { "Ascending", "Descending" };

            cbGrades.DataSource = validGrades;
            //  SchoolEntities schoolEntities = new SchoolEntities();
            //grdStudents.DataSource = schoolEntities.tbStudents.ToList();

            //   grdStudents.DataSource = schoolEntities.tbStudents
            //   .Where(x => x.Email.Contains("fa"))
            //   .OrderBy(x => x.Grade)
            //   .ToList();

            //var student = schoolEntities.tbStudents
            //    .Where(x => x.StudentID == 1)
            //    .First(); 
            //If no student is found, .First() throws an exception:
            //If no match is found, .FirstOrDefault() returns null instead of throwing an error:



            //     var user = new tbUser() { UserName = "test1", Password = "test1" };

            //  schoolEntities.tbUsers.Add(user);
            //   schoolEntities.SaveChanges();

            //   int count = schoolEntities.tbStudents
            //        .Where(x => x.FirstName.Contains(""))
            //     .Count();
            LoadStudents();


        }
        private void LoadStudents()
        {
            using (SMSEntities smsEntities = new SMSEntities())
            {
                grdStudents.DataSource = smsEntities.tbStudents.ToList();
            }
        }

        private bool ValidateStudentInput()
        {
            lbFNameMsg.Text = lbLNameMsg.Text = lbAgeMsg.Text = lbGradeMsg.Text = lbEmailMsg.Text = lbDOBMsg.Text = string.Empty;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                lbFNameMsg.Text = "First Name must be provided.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbLNameMsg.Text = "Last Name must be provided.";
                isValid = false;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age <= 0)
            {
                lbAgeMsg.Text = "Please enter a valid positive number for Age.";
                isValid = false;
            }



            if (!Util.IsValidEmail(tbEmail.Text.Trim()))
            {
                lbEmailMsg.Text = "Please enter a valid Email.";
                isValid = false;
            }

            if (dateTimePicker.Value > DateTime.Now)
            {
                lbDOBMsg.Text = "Date of Birth cannot be in the future.";
                isValid = false;
            }

            return isValid;
        }

        private void btnAddPannel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            newStudentPanel.Visible = true;


        }



        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = grdStudents.CurrentRow;
                PopulateFormFieldsFromSelectedRow(selectedRow);
                newStudentPanel.Visible = true;
                panel1.Visible = false;
                lbTitle.Text = "Update Student";
                btnSubmitUpdate.Visible = true;
            }
            else if (grdStudents.SelectedRows.Count > 1)
            {
                MessageBox.Show("Only one student's information can be updated at a time.", "Update Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a student first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBack2_Click_1(object sender, EventArgs e)
        {
            newStudentPanel.Visible = false;
            panel1.Visible = true;
            btnSubmitUpdate.Visible = false;
            lbTitle.Text = "New Student";
            tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
            cbGrades.SelectedItem = "A";
            dateTimePicker.Value = DateTime.Now;
        }

        private tbStudent CreateStudentFromInput()
        {
            return new tbStudent()
            {
                FirstName = tbFirstName.Text.Trim(),
                LastName = tbLastName.Text.Trim(),
                Age = int.Parse(tbAge.Text),
                Email = tbEmail.Text.Trim(),
                Grade = cbGrades.SelectedItem.ToString(),
                DateOfBirth = dateTimePicker.Value.Date
            };
        }
        private void PopulateFormFieldsFromSelectedRow(DataGridViewRow selectedRow)
        {
            tbFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
            tbLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
            tbAge.Text = selectedRow.Cells["Age"].Value.ToString();
            cbGrades.SelectedItem = selectedRow.Cells["Grade"].Value.ToString();
            tbEmail.Text = selectedRow.Cells["Email"].Value.ToString();

            dateTimePicker.Value = DateTime.Parse(selectedRow.Cells["DateOfBirth"].Value.ToString());
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
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
                        MessageBox.Show("This email is already registered. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var newStudent = CreateStudentFromInput();

                    smsEntities.tbStudents.Add(newStudent);
                    smsEntities.SaveChanges();

                    tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                    cbGrades.SelectedItem = "A"; 
                    dateTimePicker.Value = DateTime.Now;

                    // Refresh the DataGridView
                    LoadStudents();

                    MessageBox.Show("Student has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                int studentID = int.Parse(grdStudents.CurrentRow.Cells["StudentID"].Value.ToString());

                var existingStudent = smsEntities.tbStudents.FirstOrDefault(s => s.StudentID == studentID); //existingStudent is now a reference to that database record (not a copy).
                bool emailExists = smsEntities.tbStudents.Any(s => s.Email == tbEmail.Text.Trim() && s.StudentID != studentID);
                if (emailExists)
                {
                    MessageBox.Show("This email is already registered. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var updatedStudent = CreateStudentFromInput();

                // Copying values from updatedStudent to existingStudent
                existingStudent.FirstName = updatedStudent.FirstName;
                existingStudent.LastName = updatedStudent.LastName;
                existingStudent.Age = updatedStudent.Age;
                existingStudent.Email = updatedStudent.Email;
                existingStudent.Grade = updatedStudent.Grade;
                existingStudent.DateOfBirth = updatedStudent.DateOfBirth;

                smsEntities.SaveChanges();

                tbFirstName.Text = tbLastName.Text = tbAge.Text = tbEmail.Text = string.Empty;
                cbGrades.SelectedItem = "A";
                dateTimePicker.Value = DateTime.Now;
                newStudentPanel.Visible = false;
                panel1.Visible = true;
                // Refresh the DataGridView
                LoadStudents();

                MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one Student to Delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<int> lstIdsToDelete = new List<int>();
            foreach (DataGridViewRow currentrow in grdStudents.SelectedRows)
            {
                lstIdsToDelete.Add((int)currentrow.Cells["StudentID"].Value);
            }

            // Confirmation message box
            DialogResult result = MessageBox.Show(    //A variable which stores dufferent values returned from message box
                "Are you sure you want to delete the selected student(s)?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
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
                MessageBox.Show("Students Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SMSEntities smsEntities = new SMSEntities()) {
                string searchValue = tbSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchValue)) {
                    grdStudents.DataSource = smsEntities.tbStudents.ToList();
                    return;
                }
                var students =  smsEntities.tbStudents.Where(s =>
                s.FirstName.Contains(searchValue) ||
                s.LastName.Contains(searchValue) ||
                s.Email.Contains(searchValue) ||
                s.Grade.Contains(searchValue) ||
                s.Age.ToString().Contains(searchValue) 
                );
                grdStudents.DataSource = students.ToList();
            }
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (fdExportCSV.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            IList<SMSStudent> lstStudents = Util.GetAllStudents();
            fdExportCSV.Filter = "All files (*.*)|*.*";
            fdExportCSV.FileName = "report.txt"; //Default Name
            fdExportCSV.Title = "Report";

            try
            {
                if (lstStudents.Count == 0)
                {
                    MessageBox.Show("No students found to generate a report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show($"Report generated successfully", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (fdExportCSV.ShowDialog() == DialogResult.OK) // User selects a file
                {
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
                                        "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (fdImportCSV.ShowDialog() == DialogResult.OK)
                {
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
                                                    "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }

                                string firstName = data[0].Trim();
                                string lastName = data[1].Trim();

                                // Validate Age
                                if (!int.TryParse(data[2].Trim(), out int age) || age <= 0)
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid age value ({data[2]}).",
                                                    "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }

                                string grade = data[3].Trim();
                                string email = data[4].Trim();

                                if (!Util.IsValidEmail(email))
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid email format ({email}).",
                                                    "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    continue;
                                }

                                // Validate and parse DateOfBirth correctly
                                if (!DateTime.TryParseExact(data[5].Trim(), "yyyy-MM-dd",
                                                            CultureInfo.InvariantCulture,
                                                            DateTimeStyles.None, out DateTime dob))
                                {
                                    MessageBox.Show($"Error on line {lineNumber}: Invalid Date of Birth format ({data[5]}). Expected format: yyyy-MM-dd",
                                                    "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                        "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grdStudents.DataSource = null; // Refresh UI
                        grdStudents.DataSource = context.tbStudents.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing from CSV: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbSort.SelectedItem == null || cbSortOrder.SelectedItem == null)
            {
                MessageBox.Show("Please select sorting criteria and order.", "Sorting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCriteria = cbSort.SelectedItem.ToString();
            string sortOrder = cbSortOrder.SelectedItem.ToString(); // Ascending or Descending

            using (SMSEntities context = new SMSEntities()) // Your DbContext
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
                        MessageBox.Show("Invalid sorting option selected.", "Sorting Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                grdStudents.DataSource = query.ToList(); // Fetch sorted data
            }
        }

    }
}
