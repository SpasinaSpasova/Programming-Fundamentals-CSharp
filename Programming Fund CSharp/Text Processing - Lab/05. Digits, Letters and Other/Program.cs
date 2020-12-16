using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (char.IsLetter(current))
                {
                    letters.Append(current);
                }
                else if (char.IsDigit(current))
                {
                    digits.Append(current);

                }
                else
                {
                    other.Append(current);
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
