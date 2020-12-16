using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(string.Join(" ",arr.Reverse()));

        }
    }
}
