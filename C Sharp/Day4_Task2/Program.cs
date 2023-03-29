using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day4_Task2
{

    public class Student_details
    {
        private readonly int studentID;
        private readonly string studentName;
        private readonly string studentEmail;
        private decimal studentGPA { get; set; }

        private readonly int studentRoll;
        private string studentDOB { get; set; }
        private decimal studentCGPA { get; set; }
        private decimal[] GPAarray { get; set; }

        private string name { get; set; }
        public string inputmail { get; private set; }

        public enum gpa
        {
            GPA1 = 1,
            GPA2 = 2,
            GPA3 = 3,
            GPA4 = 4,
            GPA5 = 5
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            return Regex.IsMatch(email, pattern);
        }

        static void Main(string[] args)
        {
            try
            {
                Student_details student1 = new Student_details();
                Student_details student2 = new Student_details();
                Student_details student3 = new Student_details();
                Student_details student4 = new Student_details(student3);

                var students = new List<Student_details> { student1, student2, student3 };
                var maxCGPA = students.Max(s => s.studentCGPA);
                var topStudents = students.Where(s => s.studentCGPA == maxCGPA).ToList();


                if (topStudents.Count == 3)
                {
                    Console.WriteLine("All three students are CRs!");
                }
                else if (topStudents.Count == 2)
                {
                    Console.WriteLine(topStudents[0].studentName + " and " + topStudents[1].studentName + " are both CRs!");
                }
                else if (topStudents.Count == 1)
                {
                    Console.WriteLine(topStudents[0].studentName + " is the CR!");
                }
                else
                {
                    Console.WriteLine("No winner found.");
                }

                Console.WriteLine(student4.name);

                var result = student1 + student2;

                Console.WriteLine(result);

                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

        }
        public Student_details()
        {
            Console.WriteLine("Enter Student ID :");

            while(!Int32.TryParse(Console.ReadLine(),out studentID))
            {
                Console.WriteLine("Enter valid id");
            }
        

            Console.WriteLine("Enter Student Name :");
            studentName = Convert.ToString(Console.ReadLine());
                
            do
            {
                Console.WriteLine("Enter valid Email :");
                inputmail = Convert.ToString(Console.ReadLine());
                studentEmail = inputmail;
            }
            while (!IsValidEmail(inputmail));
       

            Console.WriteLine("Enter Student Roll.No.");
            studentRoll = Convert.ToInt32(Console.ReadLine());

            GPAarray = new decimal[5];

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Enter GPA for " + (i + 1) + " Semester");

                Console.WriteLine("Press 1 For 1 GPA\nPress 2 For 2 GPA\nPress 3 For 3 GPA\nPress 4 For 4 GPA\nPress 5 for 5 GPA");

                var inputCGPA = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputCGPA))
                {

                    var studentGPA = Convert.ToDecimal(inputCGPA);
                    switch (studentGPA)
                    {
                        case 1:
                            GPAarray[i] = (decimal)gpa.GPA1;
                            break;
                        case 2:
                            GPAarray[i] = (decimal)gpa.GPA2;
                            break;
                        case 3:
                            GPAarray[i] = (decimal)gpa.GPA3;
                            break;
                        case 4:
                            GPAarray[i] = (decimal)gpa.GPA4;
                            break;
                        case 5:
                            GPAarray[i] = (decimal)gpa.GPA5;
                            break;
                        default:
                            GPAarray[i] = (decimal)gpa.GPA3;
                            break;

                    }
                }
                else
                {
                    GPAarray[i] = (decimal)gpa.GPA3;
                }


            }
            studentCGPA = (decimal)Queryable.Average(GPAarray.AsQueryable());
            Console.WriteLine(studentCGPA);
        }

        public Student_details(Student_details student3)
        {
            name = student3.studentName;
        }

        public static string operator +(Student_details student1, Student_details student2)
        {
            var result = student1.studentName + " " + student2.studentName;
            return result;
        }
    }
}
