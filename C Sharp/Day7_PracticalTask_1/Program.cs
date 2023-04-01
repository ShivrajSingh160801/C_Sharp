using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_PracticalTask_1_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tasks.Task1();
        }
    }
    public static class Tasks
    {
        public static void Task1()
        {
            ArrayList originalList = new ArrayList();

            Console.WriteLine("Enter Length of List");

            var ListLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ListLength; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " Element");
                originalList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\nOriginal List is");

            foreach (int i in originalList)
            {
                Console.WriteLine(i);
            }

            ArrayList resultList = new ArrayList();
            resultList.Capacity = originalList.Capacity;


            for (int i = 0; i < originalList.Count; i++)
            {
                var num = ((int)originalList[i] + 2) * 5;
                resultList.Add(num);
            }

            Console.WriteLine("\nRequirement : ");
            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine($"({originalList[i]} + 2) x 5 = {resultList[i]}");
            }

            Console.WriteLine("\nResultant List = ");
            foreach (int i in resultList)
            {
                Console.WriteLine(i);
            }
        }
    }


}
