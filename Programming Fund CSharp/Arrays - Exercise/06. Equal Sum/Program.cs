using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();


            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int k = 0; k < i; k++)
                {
                    left += arr[k];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    right += arr[j];
                }
                if (right == left)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

        }
    }
}
