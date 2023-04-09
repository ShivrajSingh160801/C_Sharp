using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8_PracticalTask
{
    public class Employee
    {
        static void Main(string[] args)
        {
            var employee = new employeeDetails();

            Console.WriteLine("Press 1 To Enter New Employee\nPress 2 To View Employee");
            switch (Console.ReadLine())
            {
                case "1":
                    employee.employeeDetail();
                    break;
                case "2":
                    employee.viewAllEmployees();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }

    public class employeeDetails
    {
        public string firstName;

        public string lastName;

        private enum gender
        {
            Male, Female
        }

        public string Gender { get; set; }
        private string email { get; set; }

        public Int64 phone { get; set; }

        public enum selectDesignation
        {
            Developer, QA, Trainee, BA, HR
        }

        public string designation { get; set; }

        private bool isValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            return Regex.IsMatch(email, pattern);
        }

        private bool isValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            string pattern = @"^[6789]\d{9}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }
        public void employeeDetail()
        {
            bool flag = false;

            do
            {
                Console.WriteLine("Enter Employee Details");
                Console.WriteLine("x----------------x");

                List<employeeDetails> employees = new List<employeeDetails>();
                if (File.Exists("employees.json"))
                {
                    string jsonString = File.ReadAllText("employees.json");
                    employees = JsonConvert.DeserializeObject<List<employeeDetails>>(jsonString);
                }
                bool firstNameSuccess = true;

                while (firstNameSuccess)
                {
                    Console.Write("Enter your first name: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^[A-Za-z]+$"))
                    {
                        firstName = input;
                        firstNameSuccess = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid first name.");
                        firstNameSuccess = true;
                    }
                }
                bool lastNameSuccess = true;

                while (lastNameSuccess)
                {
                    Console.Write("Enter your last name: ");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^[A-Za-z]+$"))
                    {
                        lastName = input;
                        lastNameSuccess = false;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid last name.");
                    }
                }

                string selectedGender = "";
                do
                {
                    Console.WriteLine("Choose Gender - \nEnter F for Female\nEnter M for Male");
                    selectedGender = Console.ReadLine().ToUpper();
                    switch (selectedGender)
                    {
                        case "F":
                            Gender = gender.Female.ToString();
                            Console.WriteLine("Gender Selected - " + Gender);
                            break;
                        case "M":
                            Gender = gender.Male.ToString();
                            Console.WriteLine("Gender Selected - " + Gender);
                            break;
                    }

                }
                while (string.IsNullOrEmpty(selectedGender) || (selectedGender != "F" && selectedGender != "M"));



                string selectedDesignation;
                bool validInput = false;

                do
                {
                    Console.WriteLine("Choose Designation - \nPress 1 for Developer\nPress 2 for QA\nPress 3 for Trainee\nPress 4 for BA\nPress 5 for HR");
                    selectedDesignation = Console.ReadLine();

                    switch (selectedDesignation)
                    {
                        case "1":
                            designation = selectDesignation.Developer.ToString();
                            Console.WriteLine("You Chose - " + designation);
                            validInput = true;
                            break;
                        case "2":
                            designation = selectDesignation.QA.ToString();
                            Console.WriteLine("You Chose - " + designation);
                            validInput = true;
                            break;
                        case "3":
                            designation = selectDesignation.Trainee.ToString();
                            Console.WriteLine("You Chose - " + designation);
                            validInput = true;
                            break;
                        case "4":
                            designation = selectDesignation.BA.ToString();
                            Console.WriteLine("You Chose - " + designation);
                            validInput = true;
                            break;
                        case "5":
                            designation = selectDesignation.HR.ToString();
                            Console.WriteLine("You Chose - " + designation);
                            validInput = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please choose between 1 - 5");
                            break;
                    }

                }
                while (!validInput);

                do
                {
                    Console.WriteLine("Enter valid Email :");
                    email = Convert.ToString(Console.ReadLine());

                }
                while (!isValidEmail(email));

                string phoneNumber;

                do
                {
                    Console.WriteLine("Enter valid Phone Number :");
                    phoneNumber = Console.ReadLine();
                    try
                    {
                        phone = Convert.ToInt64(phoneNumber);
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Invalid phone number. Please enter a valid number.");
                        continue;
                    }
                }
                while (!isValidPhoneNumber(phoneNumber));

                var EmployeeDetailObject = new employeeDetails()
                {
                    firstName = firstName,
                    lastName = lastName,
                    Gender = Gender,
                    designation = designation,
                    email = email,
                    phone = phone
                };

                employees.Add(EmployeeDetailObject);

                string fileName = "employees.json";
                string jsonConvert = JsonConvert.SerializeObject(employees);

                if (File.Exists("employees.json"))
                {
                    File.WriteAllText(fileName, jsonConvert);
                }
                else
                {
                    File.Create(fileName);
                    File.WriteAllText(fileName, jsonConvert);
                    Console.WriteLine("File Created");
                }

                Console.WriteLine("To Add More Employess Press --  Y\nTo Exit Press Any Key");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            while (flag);
        }
        public void viewAllEmployees()
        {
            if (File.Exists("employees.json"))
            {
                string jsonString = File.ReadAllText("employees.json");
                List<employeeDetails> employees = JsonConvert.DeserializeObject<List<employeeDetails>>(jsonString);

                foreach (employeeDetails employee in employees)
                {
                    Console.WriteLine($"Employee Name: {employee.firstName} {employee.lastName}, Person Gender : {employee.Gender}, Employee Designation : {employee.designation},Employee Email : {employee.email},Employee Phone : {employee.phone}");
                }
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }


    }

}
