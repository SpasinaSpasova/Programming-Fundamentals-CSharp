using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOffOddNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= countOffOddNum * 2; i++)
            {
                if (i%2!=0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
