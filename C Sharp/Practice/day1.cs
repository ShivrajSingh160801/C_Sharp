using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class day1
    {
        public void task1()
        {
            Console.WriteLine("Enter Any Number");
            double ReqNum = Convert.ToDouble(Console.ReadLine());
            if (ReqNum > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (ReqNum < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (ReqNum == 0)
            {
                Console.WriteLine("Zero");
            }
        }

        public void task2()
        {
            Console.WriteLine("Enter The Day of Week");
            double day = Convert.ToDouble(Console.ReadLine());
            switch (day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter Number Between 1-7");
                    break;
            }
        }


        public void task3()
        {
            Console.WriteLine("Enter 1st Number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("For Maximum-- Type max \n For Minimum-- Type min");
            var requirement = Console.ReadLine().ToLower();
            if (requirement == "max")
            {
                Console.WriteLine(Math.Max(firstNumber, secondNumber));
            }
            else if (requirement == "min")
            {
                Console.WriteLine(Math.Min(firstNumber, secondNumber));
            }
          
        }

        public void task4()
        {
            Console.WriteLine("Enter temperature In Celcius");
            double Temparature = Convert.ToDouble(Console.ReadLine());
            if (Temparature < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if (Temparature > 0 && Temparature <= 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (Temparature > 10 && Temparature <= 20)
            {
                Console.WriteLine("Cold Weather");
            }
            else if (Temparature > 20 && Temparature <= 30)
            {
                Console.WriteLine("Normal Tempertaure");
            }
            else if (Temparature > 30 && Temparature < 40)
            {
                Console.WriteLine("It's Hot");
            }
            else
            {
                Console.WriteLine("Very Hot");
            }
        }

        public void task5()
        {
            Console.WriteLine("Enter 1st Number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1: To Add \n Press 2: To Substract \n Press 3: To Multiply \n Press 4: To Divide");
            var command = Convert.ToDouble(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.WriteLine(number1 + number2);
                    break;

                case 2:
                    Console.WriteLine(number1 - number2);
                    break;

                case 3:
                    Console.WriteLine(number1 * number2);
                    break;

                case 4:
                    Console.WriteLine(number1 / number2);
                    break;

                default:
                    Console.WriteLine("Check For Selected Option");
                    break;
            }
        }

    }




    }

