using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)

        {

			try
			{
          
                bool flag = false;
                var objectName = new day1();
                do
                {
                    Console.WriteLine("Enter Task Number To Check");

                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        switch (num)
                        {
                            case 1:
                                objectName.task1();
                                break;

                            case 2:
                                objectName.task2();
                                break;

                            case 3:
                                objectName.task3();
                                break;

                            case 4:
                                objectName.task4();
                                break;

                            case 5:
                                objectName.task5();
                                break;

                            default:
                                Console.WriteLine("There are Only 5 Task");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Number");
                    }

                    Console.WriteLine("To Continue Press = Y \n To End Press N");
                    var flagValue = Console.ReadLine();
                    if (flagValue == "Y")
                    {
                        flag = true;
                    }
                    else if (flagValue == "N")
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


