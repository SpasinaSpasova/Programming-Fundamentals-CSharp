using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {

                PrintLine(1, i);
            }
            for (int i = count-1; i >= 1; i--)
            {
                PrintLine(1, i);

            }
        }

        static void PrintLine(int start, int i)
        {
            for (int j = start; j <= i; j++)
            {
                Console.Write(j + " ");

            }
            Console.WriteLine();

        }
    }
}
