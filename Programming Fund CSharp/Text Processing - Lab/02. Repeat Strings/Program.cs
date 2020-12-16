using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                string current = line[i];

                for (int j = 0; j < current.Length; j++)
                {
                    sb.Append(current);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
