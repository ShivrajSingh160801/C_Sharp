using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the numbers you want to compress, separated by commas: ");
        string input = Console.ReadLine();
        int[] numbers = input.Split(',').Select(Int32.Parse).ToArray();
        Array.Sort(numbers);
        string compressed = CompressNumbers(numbers);
        Console.WriteLine(compressed);
    }

    static string CompressNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return "";
        }

        var ranges = new List<(int, int)>(); 
        int start = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[i - 1] + 1)
            {
                ranges.Add((start, numbers[i - 1])); 
                start = numbers[i];
            }
        }

        ranges.Add((start, numbers[numbers.Length - 1]));

        return String.Join(",", ranges.Select(r => r.Item1 == r.Item2 ? r.Item1.ToString() : r.Item1.ToString() + "-" + r.Item2.ToString()));
    }
}
