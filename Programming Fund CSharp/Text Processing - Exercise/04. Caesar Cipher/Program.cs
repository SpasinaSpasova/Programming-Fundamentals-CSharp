using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char current = (char)(input[i] + 3);
                result.Append(current);
            }
            Console.WriteLine(result);
        }
    }
}
