using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)(?<user>[a-zA-Z]+[\.\-]*\w*)@(?<host>[a-zA-Z]+?([\-\.]\w*)*(\.[a-zA-Z]{2,}))";

            MatchCollection theEnd = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(Environment.NewLine,theEnd));
        }
    }
}
