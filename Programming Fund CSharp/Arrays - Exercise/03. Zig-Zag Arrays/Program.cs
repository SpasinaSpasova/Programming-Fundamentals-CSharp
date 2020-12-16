using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] first = new string[count];
            string[] second = new string[count];
            for (int i = 0; i < count; i++)
            {
                string[] nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (i % 2 == 0)
                {
                    first[i] = nums[0];
                    second[i] = nums[1];
                   
                }
                else
                {
                    first[i] = nums[1];
                    second[i] = nums[0];
                }

            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}
