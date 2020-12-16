using System;
using System.Runtime.InteropServices;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                int current = i;
                int sum = 0;
                bool odd = false;
                while (current > 0)
                {
                    int digit = current % 10;
                    sum += digit;
                    if (digit % 2 != 0)
                    {
                        odd = true;
                    }


                    current /= 10;

                }
                if (sum % 8 == 0 && odd)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
