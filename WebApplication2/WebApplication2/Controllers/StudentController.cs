using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly SmsContext context;

        public StudentController(ILogger<StudentController> logger, SmsContext smsContext)
        {
            _logger = logger;
            context = smsContext;
        }
        public IActionResult List()
        {
            List<TbStudent> StudentList = context.TbStudents.ToList();

            return View(StudentList);
        }
        public IActionResult Add()
        {
            TbStudent Student = new TbStudent();
            return View(Student);
        }


        [HttpPost]
        [HttpPost]
        public IActionResult Submit(TbStudent student)
        {
            bool emailExists = context.TbStudents.Any(e => e.Email == student.Email);
            if (emailExists)
            {

                ModelState.AddModelError("Email", "This email already exists.");
                return View("Add", student);
            }
            if (!ModelState.IsValid)
            {
                return View("Add", student); // Return the form with validation messages
            }

            context.TbStudents.Add(student);
            context.SaveChanges();
            return RedirectToAction("List");
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var student = context.TbStudents.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                context.TbStudents.Remove(student);
                context.SaveChanges();
            }

            return Ok(); //Ok(): This is a method that creates a response with the HTTP status code 200 (OK). It indicates that the request was successfully processed by the server.
        }

        public IActionResult Edit(int id)
        {
            var student = context.TbStudents.FirstOrDefault(s => s.StudentId == id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Save(TbStudent updatedStudent)
        {
            bool emailExists= context.TbStudents.Any(e=>e.Email == updatedStudent.Email);
            if (emailExists) {

                ModelState.AddModelError("Email", "This email already exists.");
                return View("Edit",updatedStudent);
            }
            if (!ModelState.IsValid)
            {
                return View("Edit",updatedStudent);
            }
                context.Update(updatedStudent);
                context.SaveChanges();


            return RedirectToAction("List"); 
        }

        public IActionResult Sort(string order)
        {
            IQueryable<TbStudent> students = context.TbStudents;

            // Default sort column if none provided
            order = string.IsNullOrEmpty(order) ? "StudentId" : order;

            // Apply sorting based on the order parameter
            students = order switch
            {
                "FirstName" => students.OrderBy(s => s.FirstName),
                "LastName" => students.OrderBy(s => s.LastName),
                "Age" => students.OrderBy(s => s.Age),
                "Grade" => students.OrderBy(s => s.Grade),
                "DateOfBirth" => students.OrderBy(s => s.DateOfBirth),
                "Email" => students.OrderBy(s => s.Email),
                _ => students.OrderBy(s => s.StudentId), // default if unknown column
            };

            return View("List", students.ToList());
        }
        [HttpGet]
        public IActionResult GenerateReport()
        {
            var lstStudents = context.TbStudents.ToList();

            if (lstStudents.Count == 0)
            {
                TempData["Error"] = "No students found to generate a report.";
                return RedirectToAction("List"); // or any view you want to return
            }

            int totalStudents = lstStudents.Count;
            double averageAge = lstStudents.Average(s => s.Age);

            var gradeCounts = lstStudents
                .GroupBy(s => s.Grade)
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

            byte[] fileBytes = Encoding.UTF8.GetBytes(report.ToString());
            string fileName = "report.txt";

            return File(fileBytes, "text/plain", fileName);
        }
        [HttpGet]
        public IActionResult ExportStudents()
        {
            var students = context.TbStudents
                .Select(s => new
                {
                    s.FirstName,
                    s.LastName,
                    s.Age,
                    s.Grade,
                    s.Email,
                    s.DateOfBirth
                })
                .ToList();

            if (students.Count == 0)
            {
                TempData["Error"] = "No students to export.";
                return RedirectToAction("List");
            }

            var sb = new StringBuilder();
            sb.AppendLine("FirstName,LastName,Age,Grade,Email,DateOfBirth");

            foreach (var s in students)
            {
                string line = $"{s.FirstName},{s.LastName},{s.Age},{s.Grade},{s.Email},{s.DateOfBirth:yyyy-MM-dd}";
                sb.AppendLine(line);
            }

            byte[] csvBytes = Encoding.UTF8.GetBytes(sb.ToString()); 
            /*return File(...)	Requires byte[] to send raw data
            Sending downloadable files	Browser expects byte stream + MIME type (ASP.NET strings or objects are not accepted) 
            Encoding.UTF8.GetBytes()	Converts string to proper byte format*/
            return File(csvBytes, "text/csv", "students.csv");
        }
        [HttpPost]
        public IActionResult ImportStudents(IFormFile csvFile)
        {
            if (csvFile == null || csvFile.Length == 0)
            {
                TempData["Error"] = "No file selected.";
                return RedirectToAction("List");
            }

            try
            {
                using var stream = new StreamReader(csvFile.OpenReadStream());
                var lineNumber = 1;
                var studentsToAdd = new List<TbStudent>();

                stream.ReadLine(); 

                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine(); 
                    lineNumber++;

                    var data = line.Split(',');

                    if (data.Length != 6)
                    {
                        TempData["Error"] = $"Line {lineNumber}: Incorrect number of fields.";
                        continue;
                    }

                    string firstName = data[0].Trim();
                    string lastName = data[1].Trim();
                    int.TryParse(data[2].Trim(), out int age);
                    string grade = data[3].Trim();
                    string email = data[4].Trim();

                    DateTime.TryParseExact(
                        data[5].Trim(),
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime dob
                    );

                    bool exists = context.TbStudents.Any(s => s.Email == email);
                    if (!exists)
                    {
                        studentsToAdd.Add(new TbStudent
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Grade = grade,
                            Email = email,
                            DateOfBirth = dob
                        });
                    }
                }

                if (studentsToAdd.Any())
                {
                    context.TbStudents.AddRange(studentsToAdd);
                    context.SaveChanges(); 
                    TempData["Message"] = $"{studentsToAdd.Count} students imported successfully.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error importing: {ex.Message}";
            }

            return RedirectToAction("List");
        }


    }
}

