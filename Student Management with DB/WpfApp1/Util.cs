using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace WpfApp1
{
    public class Util
    {

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|edu|org|net|gov|pk|info)$";

            /*
            Explanation:
            ^                  -> Start of the string
            [a-zA-Z0-9._%+-]+  -> Local part: allows letters, numbers, dots, underscores, %, +, and - 
            @                  -> Ensures the presence of '@'
            [a-zA-Z0-9.-]+     -> Domain part: allows letters, numbers, dots, and hyphens
            \.                 -> Matches a literal dot '.'
            (com|edu|org|net|gov|pk|info) -> Allowed domain extensions
            $                  -> End of the string
            */

            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }


    }
    public class SMSStudent
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
