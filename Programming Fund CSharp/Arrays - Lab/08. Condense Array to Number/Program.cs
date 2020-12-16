using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            int sum = 0;
            while (arr1.Length != 1)
            {
                int[] newArr = new int[arr1.Length - 1];

                for (int i = 0; i < newArr.Length; i++)
                {
                    sum = arr1[i] + arr1[i + 1];
                    newArr[i] = sum;
                }

                arr1 = newArr;


            }
            Console.WriteLine(arr1[0]);
        }
    }
}
