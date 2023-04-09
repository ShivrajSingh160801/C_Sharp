using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_sharp_Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag = true; 
                Employee employee = new Employee();
                while (flag)
                {
                    Console.WriteLine("Enter 1 to Add New Employee\nEnter 2 to Exit");
                    var num = Console.ReadLine();

                    switch (num)
                    {
                        case "1":
                            employee.employeeDetail();
                            break;

                        case "2":
                            flag = false; 
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Choose 1, 2, or 3.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
