using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> second = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> result = new List<int>();

            int max = Math.Max(first.Count, second.Count);
            int min = Math.Min(first.Count, second.Count);

            for (int i = 0; i < min; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            for (int i = min; i < max; i++)
            {
                if (second.Count > first.Count)
                {

                    result.Add(second[i]);
                }
                else
                {

                    result.Add(first[i]);
                }

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
