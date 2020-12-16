using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                if (current%2==0)
                {
                    evenSum += current;
                }
                else
                {
                    oddSum += current;
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
