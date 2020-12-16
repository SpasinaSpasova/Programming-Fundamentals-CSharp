using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^%$!.]*\<(?<product>\w+)\>[^%$!.]*\|(?<quantity>\d+)\|[^%$!.]*?(?<price>\d+([.]\d+)?)\$";


            string input = Console.ReadLine();
            double total = 0;
            StringBuilder theEnd = new StringBuilder();
            while (input != "end of shift")
            {
                var regex = Regex.Match(input, pattern);

                if (regex.Success)
                {
                    double price = double.Parse(regex.Groups["quantity"].Value) *
                        double.Parse(regex.Groups["price"].Value);
                    theEnd.AppendLine($"{regex.Groups["customer"]}: {regex.Groups["product"]} - {price:f2}");
                    total += price;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(theEnd.ToString().TrimEnd());
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}