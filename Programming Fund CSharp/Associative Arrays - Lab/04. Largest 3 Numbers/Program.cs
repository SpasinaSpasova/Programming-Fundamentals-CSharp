using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbs = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .OrderByDescending(x =>x)
                 .ToList();
            if (numbs.Count>3)
            {
                Console.WriteLine(string.Join(" ",numbs.Take(3)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",numbs));

            }
        }
    }
}
