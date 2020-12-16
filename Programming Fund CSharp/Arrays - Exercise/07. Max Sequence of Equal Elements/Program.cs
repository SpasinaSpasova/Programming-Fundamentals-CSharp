using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int countLen = 1;
            int bestCountLen = 0;

            int startIndex = 0;
            int bestIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    countLen++;
                }
                else
                {
                    countLen = 1;
                    startIndex = i;
                }

                if (countLen>bestCountLen)
                {
                    bestCountLen = countLen;
                    bestIndex = startIndex;
                }
            }
            for (int i = bestIndex; i < bestIndex+bestCountLen; i++)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
}
