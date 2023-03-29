using System;
using System.Configuration;
using System.Linq;

namespace Task;

class Program
{
    static void Main(String[] args)
    {

        try
        {

            Console.WriteLine("Please Enter The task to Check");
            var userinput = Convert.ToInt64(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    Day3tasks.task1();
                    break;

                case 2:
                    DateTime todaydate = DateTime.Today;
                    string format = "dddd, dd MMMM yyyy";
                    string requiredformat = todaydate.DateFormate(format);
                    Console.WriteLine(requiredformat);


                    break;

                case 3:
                    string hello = null;
                    Day3tasks.task10(hello);
                    break;

                case 4:
                    Day3tasks.task11();
                    break;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


}
