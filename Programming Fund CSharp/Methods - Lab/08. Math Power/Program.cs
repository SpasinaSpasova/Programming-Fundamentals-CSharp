using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = TheResult(number,power);
            Console.WriteLine(result);
        }

        static double TheResult(double num, double pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
