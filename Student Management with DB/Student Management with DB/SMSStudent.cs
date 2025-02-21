using System;

namespace Student_Management_with_DB
{
    internal class SMSStudent
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
