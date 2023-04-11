using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_sharp_Exam
{
    public class EmployeeDataMembers
    {
        public int employeeID { get; set; }

        public bool isValidId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            string pattern = @"^[0-9]{6}$";

            return Regex.IsMatch(id, pattern);
        }

        public string employeeName { get; set; }

        public bool isValidname(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            string pattern = @"^[a-zA-Z ]*$";

            return Regex.IsMatch(name, pattern);
        }

        public string dateOfBirth { get; set; }

        public string Gender { get; set; }

        public enum genderelect
        {
            Male, Female
        }

        public string designation { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int postCode { get; set; }

        public long phoneNumber { get; set; }

        public bool isValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            string pattern = @"^[6789]\d{9}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        public string email { get; set; }

        public bool isValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^[^\s@]+@[^\s@]+\.(com|org|edu|info|in)$";

            return Regex.IsMatch(email, pattern);
        }

        public string dateOfJoining { get; set; }

        public string totalExperience { get; set; }

        public string remarks { get; set; }

        public string department { get; set; }


        public enum selectDepartment
        {
            Sales, Marketing, Developer, QA, HR, SEO
        }

        public double salary { get; set; }

    }
}
