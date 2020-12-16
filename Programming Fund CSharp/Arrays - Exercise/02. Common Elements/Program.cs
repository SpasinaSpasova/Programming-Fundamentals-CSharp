using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            string[] second = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            string result = "";

            for (int i = 0; i < second.Length; i++)
            {
                for (int q = 0; q < first.Length; q++)
                {
                    if (second[i]==first[q])
                    {
                        result += second[i] + " ";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
