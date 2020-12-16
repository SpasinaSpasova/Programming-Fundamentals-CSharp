using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();



            string result = "";

            for (int i = 0; i < integers.Length; i++)
            {
                bool isTop = true;
                for (int q = i+1; q < integers.Length; q++)
                {
                    if (integers[i]<=integers[q])
                    {
                        isTop = false;
                    }
                }
                if (isTop)
                {
                    result += integers[i]+ " ";
                }
            }

            Console.WriteLine(result);
        }
    }
}
