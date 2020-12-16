using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfChars = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            for (int i = 1; i <= numOfChars; i++)
            {
                char current = char.Parse(Console.ReadLine());
                sumOfChars += current;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
