using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\b?<day>[0-9]){2}(?<separator>[\-\.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d){4}\b";

            string input = Console.ReadLine();

            Regex data = new Regex(pattern);

            MatchCollection theCorect = data.Matches(input);

            foreach (Match item in theCorect)
            {
                var day = item.Groups["day"];
                var month = item.Groups["month"];
                var year = item.Groups["year"];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
