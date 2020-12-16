using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<furniture>[A-z]+)<<(?<price>\d*[.]*\d+)!(?<quantity>\d+)";

            List<string> furniture = new List<string>();
            double sum = 0;

            while (input!= "Purchase")
            {
                Regex regex = new Regex(pattern);
                var match = regex.Match(input);

                if (match.Success)
                {
                    furniture.Add(match.Groups["furniture"].Value);
                    sum += double.Parse(match.Groups["price"].Value) *
                        double.Parse(match.Groups["quantity"].Value);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,furniture));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
               
        }
    }
}
