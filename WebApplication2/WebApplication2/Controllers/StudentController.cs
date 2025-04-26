using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Submit(TbStudent vm)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", vm); // Return the form with validation messages
            }

            context.TbStudents.Add(vm);
            context.SaveChanges();
            return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {

            var student = context.TbStudents.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                context.TbStudents.Remove(student);
                context.SaveChanges();
            }

            return RedirectToAction("List"); 
        }
        public IActionResult Edit(int id)
        {
            var student = context.TbStudents.FirstOrDefault(s => s.StudentId == id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Save(TbStudent updatedStudent)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit",updatedStudent);
            }
                context.Update(updatedStudent);
                context.SaveChanges();


            return RedirectToAction("List"); 
        }


    }
}
