using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            string namePattern = @"[A-Za-z]";
            string scorePattern = @"[0-9]";

            Dictionary<string, double> dict = new Dictionary<string, double>();

            while (input != "end of race")
            {

                var nameRegex = Regex.Matches(input, namePattern);
                var scoreRegex = Regex.Matches(input, scorePattern);

                string name = string.Concat(nameRegex);
                double score = scoreRegex.Select(x => double.Parse(x.Value)).Sum();

                if (participants.Contains(name))
                {
                    if (dict.ContainsKey(name))
                    {
                        dict[name] += score;
                    }
                    else
                    {
                        dict.Add(name, score);
                    }
                }

                input = Console.ReadLine();
            }

            int count = 1;
            foreach (var item in dict.OrderByDescending(x => x.Value).Take(3))
            {
                if (count == 1)
                {

                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count==2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                count++;
            }
        }
    }
}
