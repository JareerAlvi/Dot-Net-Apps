using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student
    {

        public int StudentID { get; set; } = 0;
        public string First_Name { get; set; } = "";
        public string Last_Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public string Grade { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime DOB { get; set; } = DateTime.MinValue;

    }

}
