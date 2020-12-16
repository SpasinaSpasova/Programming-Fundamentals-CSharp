using System;
using System.Threading;

namespace _04._Refactoring_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 2; i <= count; i++)
            {
                int counter = 0;

                for (int k = 1; k <= count; k++)
                {

                    if (i % k == 0)
                    {
                        counter++;
                    }
                }

                if (counter <= 2)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");

                }
            }

        }
    }
}
