using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;




namespace Task
{
    public class Day3tasks
    {
        public static void task1()
        {
            //File Creation

            if (File.Exists("Practice4.txt"))
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                File.Create("Practice4.txt");
                Console.WriteLine("File created successfull");
            }

            //File Writing Text
            File.WriteAllText("Practice4.txt", "Hello, I Hope You Are Fine! ");

            //File Read Text
            var readText = File.ReadAllText("Practice4.txt");

            Console.WriteLine(readText);

            //File Append Text
            File.AppendAllText("Practice4.txt", "All The Best\nDon't Lose Hope!\n Good Things Take Time!\n Try to Give Your Best \n");

            var readTextappend = File.ReadAllText("Practice4.txt");

            Console.WriteLine(readTextappend);

            var readFirstline = File.ReadLines("Practice4.txt").First();

            /*   var readFirstline = File.ReadLines("Practice4.txt").ElementAtOrDefault(1)*/
            ;

            Console.WriteLine(readFirstline);

            string[] names = new string[5] { "candidate1", "candidate2", "candidate3", "candidtate4", "candidate5" };

            File.AppendAllLines("Practice4.txt", names);

            var fileArrayappend = File.ReadAllText("Practice4.txt");

            Console.Write(fileArrayappend);


            var fileslineslength = File.ReadAllLines("Practice4.txt").Length;

            Console.WriteLine("Number of lines"+fileslineslength);



            Console.WriteLine("Enter 2 numbers");
            var number1 = Convert.ToInt64(Console.ReadLine());
            var number2 = Convert.ToInt64(Console.ReadLine());

            var division = number1 / number2;
            Console.WriteLine(division);
        }

        public static void task10(string name)
        {
          
            int ans = int.Parse(name);

        }

        public static void task11()
        {

            if (File.Exists("Practice2.txt"))
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                File.Create("Practice2.txt");
                Console.WriteLine("File created successfull");
            }


            Console.WriteLine("Enter Email");
            var email = Console.ReadLine();

           string encrptedemail = EnryptString(email);
            File.AppendAllText("Practice1.txt", encrptedemail);
            string toDecrypt =File.ReadAllText("Practice1.txt");
            DecryptString(toDecrypt);
        }

        public static string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decrypted = "";
            }
            return decrypted;
        }

        public static string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
    }

    public static class DateTimeExtensions
    {
        public static string DateFormate(this DateTime date, string format)
        {
            return date.ToString(format);
        }
    }



}
