using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_sharp_Exam
{
    public class Employee
    {
        public int employeeID { get; set; }

        private bool isValidId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            string pattern = @"^[0-9]{6}$";

            return Regex.IsMatch(id, pattern);
        }

        public string employeeName { get; set; }

        private bool isValidname(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            string pattern = @"^[a-zA-Z ]*$";

            return Regex.IsMatch(name, pattern);
        }

        public string dateOfBirth { get; set; }

        public string Gender { get; set; }

        private enum genderelect
        {
            Male, Female
        }

        public string designation { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int postCode { get; set; }

        public long phoneNumber { get; set; }

        private bool isValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            string pattern = @"^[6789]\d{9}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        public string email { get; set; }

        private bool isValidEmail(string email)
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



        public void employeeDetail()
        {
            do
            {
                string filePath = ConfigurationManager.AppSettings["FilePath"];
                List<Employee> EmployeesList = new List<Employee>();

                try
                {
                    if (File.Exists(filePath))
                    {
                        string jsonString = File.ReadAllText(filePath);
                        EmployeesList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }

                Console.WriteLine("Enter Employee Details");
                Console.WriteLine("----------------");

                string testEmployeeID;
                do
                {
                    Console.WriteLine("Enter Id :");
                    testEmployeeID = Console.ReadLine();
                    try
                    {
                        employeeID = Convert.ToInt32(testEmployeeID);
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Invalid ID. Enter 6 Digit Id.");
                        continue;
                    }
                }
                while (!isValidId(testEmployeeID.ToString()) || CheckEmployeeIDExistence(employeeID));

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Enter Name Of Employee :");
                    employeeName = Console.ReadLine();
                }
                while (!isValidname(employeeName));

                Console.WriteLine("\n----------------");

                bool birthDate = true;
                while (birthDate)
                {
                    Console.Write("Enter your DOB: ");
                    string inputDOB = Console.ReadLine();
                    try
                    {
                        dateOfBirth = DateTimeExtensions.DateFormate(Convert.ToDateTime(inputDOB));
                        Console.WriteLine("Entered Date Of Birth : " + dateOfBirth);
                        birthDate = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Date Format.");
                        continue;
                    }
                }
                Console.WriteLine("\n----------------");

                string selectedGender = "";
                do
                {
                    Console.WriteLine("Choose Gender - \nEnter F for Female\nEnter M for Male");
                    selectedGender = Console.ReadLine().ToUpper();
                    switch (selectedGender)
                    {
                        case "F":
                            Gender = genderelect.Female.ToString();
                            Console.WriteLine("Gender Selected - " + Gender);
                            break;
                        case "M":
                            Gender = genderelect.Male.ToString();
                            Console.WriteLine("Gender Selected - " + Gender);
                            break;
                    }

                }

                while (string.IsNullOrEmpty(selectedGender) || (selectedGender != "F" && selectedGender != "M"));

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Enter Designation :");
                    designation = Console.ReadLine();
                }
                while (!isValidname(designation));

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Enter City :");
                    city = Console.ReadLine();
                }
                while (!isValidname(city));

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Enter State :");
                    state = Console.ReadLine();
                }
                while (!isValidname(state));

                Console.WriteLine("\n----------------");

                string testPostCode;
                do
                {
                    Console.WriteLine("Enter Postal Code :");
                    testPostCode = Console.ReadLine();
                    try
                    {
                        postCode = Convert.ToInt32(testPostCode);
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Invalid Postal Code. Postal Code consist 6 digit.");
                        continue;
                    }
                }
                while (!isValidId(testPostCode));

                Console.WriteLine("\n----------------");

                string stringphoneNumber;
                do
                {
                    Console.WriteLine("Enter valid Phone Number :");
                    stringphoneNumber = Console.ReadLine();
                    try
                    {
                        phoneNumber = Convert.ToInt64(stringphoneNumber);
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Invalid phone number. Please enter a valid number.");
                        continue;
                    }
                }
                while (!isValidPhoneNumber(stringphoneNumber));

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Enter Email :");
                    email = Console.ReadLine();
                }
                while (!isValidEmail(email));

                Console.WriteLine("\n----------------");

                bool joinDate = true;
                while (joinDate)
                {
                    Console.Write("Enter Date Of Joining : ");
                    string dateOfJoin = Console.ReadLine();
                    try
                    {
                        DateTime getJoinDate = Convert.ToDateTime(dateOfJoin);
                        dateOfJoining = DateTimeExtensions.DateFormate(getJoinDate);
                        Console.WriteLine("Your Date of Joining : " + dateOfJoining);

                        int totalMonths = (DateTime.Today.Year - getJoinDate.Year) * 12 + DateTime.Today.Month - getJoinDate.Month;

                        int years = totalMonths / 12;

                        int months = totalMonths % 12;

                       totalExperience = years + " Years , " + months + " months";


                        Console.WriteLine("Total Experience : " + years + " years and " + months + " months");
                        joinDate = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Date Format.");
                        continue;
                    }
                }

                Console.WriteLine("\n----------------");

                do
                {
                    Console.WriteLine("Remarks :");
                    remarks = Console.ReadLine();
                }
                while (!isValidname(remarks));

                Console.WriteLine("\n----------------");

                string selectedDepartment;
                bool validDepartment = false;

                do
                {
                    Console.WriteLine("Choose Department - \nPress 1 for Sales\nPress 2 for Marketing\nPress 3 for QA\nPress 4 for Developer\nPress 5 for HR\nPress 6 for SEO");
                    selectedDepartment = Console.ReadLine();

                    switch (selectedDepartment)
                    {
                        case "1":
                            department = selectDepartment.Sales.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        case "2":
                            department = selectDepartment.Marketing.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        case "3":
                            department = selectDepartment.QA.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        case "4":
                            department = selectDepartment.Developer.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        case "5":
                            department = selectDepartment.HR.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        case "6":
                            department = selectDepartment.SEO.ToString();
                            Console.WriteLine("Selected option - " + department);
                            validDepartment = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please choose between 1 - 6");
                            break;
                    }

                }
                while (!validDepartment);

                Console.WriteLine("\n----------------");
                

                do
                {
                    Console.WriteLine("Enter Your Salary:");
                    string testsalary = Console.ReadLine();

                    try
                    {
                        salary = Convert.ToDouble(testsalary);

                        if (salary < 5000 || salary > 100000)
                        {
                            Console.WriteLine("Salary must be between $5000 and $100000.");
                            continue;
                        }
                        Console.WriteLine("Your Salary is $" + salary);
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Salary Input.");
                        continue;
                    }
                }
                while (true);

                Console.WriteLine("\n----------------");

                var EmployeeObject = new Employee()
                {
                    employeeID = employeeID,
                    employeeName = employeeName,
                    dateOfBirth = dateOfBirth,
                    Gender = Gender,
                    designation = designation,
                    city = city,
                    state = state,
                    postCode = postCode,
                    phoneNumber = phoneNumber,
                    email = email,
                    dateOfJoining = dateOfJoining,
                    totalExperience = totalExperience,
                    remarks = remarks,
                    department = department,
                    salary = salary
                };

                EmployeesList.Add(EmployeeObject);

                if (EmployeesList.Count > 1)
                {
                    var sortedEmployees = EmployeesList.OrderByDescending(e => e.salary);
                    EmployeesList = sortedEmployees.ToList();
                }

                string jsonConvert = JsonConvert.SerializeObject(EmployeesList);

                try
                {
                    File.WriteAllText(filePath, jsonConvert);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing file: {ex.Message}");
                }

                Console.WriteLine("To Add More Employees Press -- Y\nTo Exit Press Any Key");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }

        public bool CheckEmployeeIDExistence(int id)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            List<Employee> employeesList = new List<Employee>();

            try
            {
                if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
                {
                    string jsonString = File.ReadAllText(filePath);
                    employeesList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            bool isExist = employeesList.Any(x => x.employeeID == id);

            if (isExist)
            {
                Console.WriteLine($"Employee ID {id} already exists in the file.");
            }

            return isExist;
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter the ID of the employee to be deleted: ");
            int id = Convert.ToInt32(Console.ReadLine());

            string filePath = ConfigurationManager.AppSettings["FilePath"];
            List<Employee> employeesList = new List<Employee>();

            try
            {
                if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
                {
                    string jsonString = File.ReadAllText(filePath);
                    employeesList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            Employee employeeToDelete = employeesList.SingleOrDefault(x => x.employeeID == id);

            if (employeeToDelete != null)
            {
                employeesList.Remove(employeeToDelete);

                try
                {
                    string jsonConvert = JsonConvert.SerializeObject(employeesList);
                    File.WriteAllText(filePath, jsonConvert);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error writing file: {ex.Message}");
                }

                Console.WriteLine($"Employee with ID {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Employee with ID {id} was not found.");
            }
        }


    }

}

