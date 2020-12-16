using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
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

            int countFirst = 0;
            int countSecond = 0;
            while (Math.Min(first.Count, second.Count)>0)
            {
                
                    if (first[0] == second[0])
                    {
                        first.RemoveAt(0);
                        second.RemoveAt(0);
                    }
                    else if (first[0] > second[0])
                    {
                        first.Add(first[0]);
                        first.Add(second[0]);
                        second.RemoveAt(0);
                        first.RemoveAt(0);
                    countFirst++;
                    }
                    else if (second[0] > first[0])
                    {
                        second.Add(second[0]);
                        second.Add(first[0]);
                        first.RemoveAt(0);
                        second.RemoveAt(0);
                    countSecond++;

                    }
         

              
            }
            if (countFirst>countSecond)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }
        }
    }
}
