using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndexOfTheChars = int.Parse(Console.ReadLine());
            int endtIndexOfTheChars = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = startIndexOfTheChars; i <= endtIndexOfTheChars; i++)
            {
                char character = (char)i;
                result += character.ToString()+ " ";
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
