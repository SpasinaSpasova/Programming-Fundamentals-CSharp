using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            string first = line[0];
            string second = line[1];
            int sum = 0;

            if (first.Length==second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += first[i] * second[i];
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else if (second.Length > first.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
