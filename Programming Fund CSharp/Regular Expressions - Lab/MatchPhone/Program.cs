using System;
using System.Text.RegularExpressions;

namespace MatchPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[359]+([\- ])[0-9]{1}\1[0-9]{3}\1[0-9]{4}\b";

            string input = Console.ReadLine();

            Regex phoneNumbers = new Regex(pattern);

            MatchCollection theCorect = phoneNumbers.Matches(input);

            Console.WriteLine(string.Join(", ", theCorect));

        }
    }
}
