using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
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

         
            List<int> mixed = new List<int>(first.Count + second.Count);

            List<int> result = new List<int>();

            for (int i = 0; i <= Math.Min(first.Count, second.Count); i++)
            {

                if (i <= second.Count - 1 && i <= first.Count - 1)
                {
                    mixed.Add(first[i]);
                    mixed.Add(second[second.Count - 1 - i]);
                    first.RemoveAt(i);
                    second.RemoveAt(second.Count - 1 - i);
                    i--;
                }
                else
                {
                    break;
                }

            }

            int big = 0;
            int small = 0;

            if (first.Count > 0)
            {
                if (first[0] >= first[1])
                {
                    big = first[0];
                    small = first[1];
                }
                else
                {
                    big = first[1];
                    small = first[0];
                }
                for (int i = 0; i < mixed.Count; i++)
                {
                    if (mixed[i] > small && mixed[i] < big)
                    {
                        result.Add(mixed[i]);
                    }
                }
            }
            else if (second.Count > 0)
            {
                if (second[0] >= second[1])
                {
                    big = second[0];
                    small = second[1];
                }
                else
                {
                    big = second[1];
                    small = second[0];
                }
                for (int i = 0; i < mixed.Count; i++)
                {
                    if (mixed[i] > small && mixed[i] < big)
                    {
                        result.Add(mixed[i]);
                    }
                }
            }

            result.Sort();
           
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
