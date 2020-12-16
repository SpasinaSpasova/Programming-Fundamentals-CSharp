using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int[] bombDate = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int bombNum = bombDate[0];
            int bombPower = bombDate[1];

            int bombIndex = numbers.IndexOf(bombNum);
            while (bombIndex != -1)
            {

                int leftIndex = bombIndex - bombPower;
                int rightIndex = bombIndex + bombPower;
                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }
                if (rightIndex > numbers.Count - 1)
                {
                    rightIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
                bombIndex = numbers.IndexOf(bombNum);
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
