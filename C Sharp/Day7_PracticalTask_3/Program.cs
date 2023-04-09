using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Practical3
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student.AddStaticStudent("John", 20, 1001, 8);
                Student.AddStaticStudent("Jane", 21, 1002, 6);
                Student.AddStaticStudent("Peter", 19, 1003, 9);
                Student.AddStaticStudent("Mary", 22, 1004, 7);
                Student.AddStaticStudent("Tom", 18, 1005, 5);

                bool flag = false;
                do
                {
                    Console.WriteLine("Press 1 For Admission\nPress 2 For Show Students\nPress 3 for Removal\nPress 4 for Award");
                    var userChoice = Convert.ToInt32(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            Student.Admission();
                            break;

                        case 2:
                            Student.ShowStudents();
                            break;

                        case 3:
                            Student.RemoveStudent();
                            break;

                        case 4:
                            Student.GiveAward();
                            break;
                    }

                    Console.WriteLine("To Perform Operation Press Y\nTo exit Press Any Key");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                } while (flag);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }

    public class Student
    {
        public static Hashtable newlyAdmitted = new Hashtable();
        public static ArrayList studentDetails = new ArrayList();

        public static void ShowStudents()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("----------------");

            foreach (DictionaryEntry entry in newlyAdmitted)
            {
                ArrayList studentvalue = (ArrayList)entry.Value;
                Console.WriteLine("Name: " + studentvalue[0]);
                Console.WriteLine("Enrollment Number: " + studentvalue[2]);
                Console.WriteLine("Academic Rating: " + studentvalue[3]);
                Console.WriteLine("----------------");
            }
        }
        public static void Admission()
        {
            bool flag = false;
            do
            {
                Console.WriteLine("Enter Student Details:");
                Console.WriteLine("Enter Name");
                studentDetails.Add(Console.ReadLine());
                Console.WriteLine("Enter Age");
                studentDetails.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter Enrollment Number (Roll No.) : ");
                int enrollmentNum = Convert.ToInt32(Console.ReadLine());
                studentDetails.Add(enrollmentNum);
                studentDetails.Add(0);  // Set academic rating to 0 for newly admitted student
                newlyAdmitted.Add(enrollmentNum, studentDetails);
                Console.WriteLine("To continue Admission Press Y\nTo exit Press Any Key");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    flag = true;
                    studentDetails = new ArrayList();
                }
                else
                {
                    flag = false;
                }
            } while (flag);
        }

        public static void AddStaticStudent(string name, int age, int enrollmentNum, int academicRating)
        {
            ArrayList studentDetails = new ArrayList();
            studentDetails.Add(name);
            studentDetails.Add(age);
            studentDetails.Add(enrollmentNum);
            studentDetails.Add(academicRating);
            newlyAdmitted.Add(enrollmentNum, studentDetails);
        }

        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the Enrollment Number of the student to remove:");
            int enrollmentNum = Convert.ToInt32(Console.ReadLine());

            if (newlyAdmitted.ContainsKey(enrollmentNum))
            {
                newlyAdmitted.Remove(enrollmentNum);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("No student found with the given Enrollment Number.");
            }
        }
        public static void GiveAward()
        {
            int highestRating = -1;
            ArrayList studentWithHighestRating = null;

            foreach (DictionaryEntry entry in newlyAdmitted)
            {
                ArrayList studentvalue = (ArrayList)entry.Value;
                int academicRating = Convert.ToInt32(studentvalue[3]);

                if (academicRating > highestRating)
                {
                    highestRating = academicRating;
                    studentWithHighestRating = studentvalue;
                }
            }

            if (studentWithHighestRating != null)
            {
                Console.WriteLine("Congratulations to {0} for achieving the highest academic rating of {1}!", studentWithHighestRating[0], highestRating);
            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }

    }

}


