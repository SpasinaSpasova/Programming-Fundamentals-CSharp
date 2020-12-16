using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern= @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string input = Console.ReadLine();

            Regex names = new Regex(pattern);
            MatchCollection rg = names.Matches(input);

            Console.WriteLine(string.Join(" ",rg));
        }
    }
}
