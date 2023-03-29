using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class day2
    {
        public void task1()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Shivraj Rathore");
            }

        }

        public void task2()
        {
            Console.WriteLine("Required Number List");
            for (var i = 1; i <= 50; i++)
            {

                if (i % 2 == 0)
                {
                    if (i % 10 == 2)
                    {
                        continue;
                    }
                    Console.Write(i + ",");
                }
            }
        }

        public void task3()
        {
            var negativecount = 0;
            Console.WriteLine("Enter The Array Length");
            var ArrayLength = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[ArrayLength];

            Console.WriteLine("Enter Values :");

            for (var i = 0; i < ArrayLength; i++)
            {
                var userinput = Convert.ToInt32(Console.ReadLine());
                Array[i] = userinput;
            }

            Console.WriteLine("Your Array is");

            for (var i = 0; i < ArrayLength; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(",");
                }
            }

            for (var i = 0; i < ArrayLength; i++)
            {
                if (Array[i] < 0)
                {
                    negativecount++;
                    continue;
                }
            }
            Console.WriteLine("\n total Number of negative values are");
            Console.WriteLine(negativecount);
        }

        public void task4()
        {
            var counteven = 0;
            var countodd = 0;

            Console.WriteLine("Enter The Array Length");
            var ArrayLength = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[ArrayLength];

            Console.WriteLine("Enter Values :");

            for (var i = 0; i < ArrayLength; i++)
            {
                var userinput = Convert.ToInt32(Console.ReadLine());
                Array[i] = userinput;
            }
            Console.WriteLine("Your Array is");

            for (var i = 0; i < ArrayLength; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(",");
                }
            }

            var EvenNumbers =
           from num in Array
           where num % 2 == 0
           select num;

          foreach (var s in EvenNumbers)
            {
                counteven++;
            }
            Console.WriteLine(" \n Total Even Number Are - " + counteven);

            var OddNumbers =
        from num in Array
        where num % 2 != 0
        select num;

            foreach (var s in OddNumbers)
            {
                countodd++;
            }
            Console.WriteLine("Total Odd Number Are - " + countodd);
        }


        public void task5()
        {
            Console.WriteLine("Enter The Array Length");
            var ArrayLength = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[ArrayLength];

            Console.WriteLine("Enter Values :");

            for (var i = 0; i < ArrayLength; i++)
            {
                var userinput = Convert.ToInt32(Console.ReadLine());
                Array[i] = userinput;
            }
            Console.WriteLine("Your Array is");

            for (var i = 0; i < ArrayLength; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("\n The Maximum Of Array is - " +Array.Max());
            Console.WriteLine("\n The Minimum Of Array is - " + Array.Min());

        }

        public void task6(string name , int age ) 
        {
            Console.WriteLine("My Name is" + name + "I am " +age +"years old");
        }

        public void task6(int age, string name)
        {
            Console.WriteLine("My Name is" + name + "I am" + age + "years old");
        }


        public void task7(int num1 , int num2) 
        {
        int add = num1 + num2;
            Console.WriteLine(add);
        }
        public void task7(int num1 , int num2 , int num3)
        {
            int add = (num1 + num2 + num3);
            Console.WriteLine(add);
        }
        public void task7(double doublenum1, double doublenum2, double doublenum3)
        {
            double add = (doublenum1 + doublenum2 + doublenum3);
            Console.WriteLine(add);
        }
    }
}
