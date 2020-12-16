using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            WhatIsNumber(number);
        }

        static void WhatIsNumber(int num)
        {
            string result = string.Empty;
            if (num<0)
            {
                result = "negative";
            }
            else if (num>0)
            {
                result = "positive";
            }
            else
            {
                result = "zero";
            }
            Console.WriteLine($"The number {num} is {result}.");
        }
    }
}
