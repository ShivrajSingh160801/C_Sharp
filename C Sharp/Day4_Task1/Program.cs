using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 Numbers");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                decimal num2 = Convert.ToDecimal(Console.ReadLine());

                Calculate.Addition(num1, num2);
                Calculate.Substraction(num1, num2);
                Calculate.Multiplication(num1, num2);
                Calculate.Division(num1, num2); 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
   public static class Calculate
    {
        public static void Addition(decimal x, decimal y) 
        {
            decimal add = (decimal)x + (decimal)y;
            Console.WriteLine("Addition - " + add);
        }

        public static void Substraction(decimal x, decimal y)
        {
            decimal substract = (decimal)x - (decimal)y;
            Console.WriteLine("Substarction - "+ substract);
        }
        public static void Multiplication(decimal x, decimal y)
        {
            decimal multiply = (decimal)x * (decimal)y;
            Console.WriteLine("Multiply - " +multiply);
        }
        public static void Division(decimal x, decimal y)
        {
            decimal divide = (decimal)x / (decimal)y;
            Console.WriteLine("Division - " +divide);
        }

    }
}
