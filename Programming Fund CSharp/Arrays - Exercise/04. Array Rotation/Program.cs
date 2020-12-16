using System;
using System.Linq;
using System.Net.Sockets;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int first = arr[0];

                int[] newArr = new int[arr.Length];

                for (int j = 1; j < arr.Length; j++)
                {
                    newArr[j-1] = arr[j];
                }

                newArr[arr.Length - 1] = first;
                arr = newArr;
            }


            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
