using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList(); //razdelqme list po "|"
            List<string> first = new List<string>();
            List<string> result = new List<string>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                first = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in first)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
