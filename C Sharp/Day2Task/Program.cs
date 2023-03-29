using System;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag = false;
                var Task2 = new day2();

                do
                {
                    Console.WriteLine("Number of Task to Check");
                    var taskcheck = Convert.ToInt32(Console.ReadLine());

                    switch (taskcheck)
                    {
                        case 1:
                            Task2.task1();
                            break;

                        case 2:
                            Task2.task2();
                            break;

                        case 3:
                            Task2.task3();
                            break;

                        case 4:
                            Task2.task4();
                            break;

                        case 5:
                            Task2.task5();
                            break;

                        case 6:
                            Console.WriteLine("Enter Name : ");
                            var name = Console.ReadLine();

                            Console.WriteLine("Enter Age");
                            var age = Convert.ToInt32(Console.ReadLine());

                            Task2.task6(name, age);
                            Task2.task6(age, name);
                            break;

                        case 7:
                            Console.WriteLine("Enter Numbers :");

                            Task2.task7(5, 6);
                            Task2.task7(9, 8, 4);
                            Task2.task7(0.2, 0.5, 4.5);

                            break;
                    }
                    Console.WriteLine("To Continue Press = Y \n To End Press N");
                    var flagValue = Console.ReadLine();
                    if (flagValue == "Y" || flagValue == "y")
                    {
                        flag = true;
                    }
                    else if (flagValue == "N" || flagValue == "n")
                    {
                        flag = false;
                    }
                }



                while (flag);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}