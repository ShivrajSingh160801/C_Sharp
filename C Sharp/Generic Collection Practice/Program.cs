using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_Practice
{
    public class Generic
    {
        static void Main(string[] args)
        {
            PracticeArrayList();

        }

        public static void PracticeArrayList()
        {
            ArrayList NewArray = new ArrayList();
            Console.WriteLine("Enter Array Length ");
            var NewArrayLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NewArrayLength; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + "Element");
               NewArray.Add( Convert.ToString (Console.ReadLine()) );
            }

            NewArray.Sort();

            NewArray.RemoveRange(0, 3);

            foreach (var item in NewArray)
            {
                Console.WriteLine(item);
            }

        }

    }


}
