using System;
using System.Globalization;
using System.Text;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="END")
            {
                Console.WriteLine(Polindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool Polindrome(string input)
        {
            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            for (int i = 0; i < reverse.Length; i++)
            {
                if (!(input[i]==reverse[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
