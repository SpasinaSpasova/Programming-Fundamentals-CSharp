using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,List<double>> dict = new Dictionary<string, List<double>>();
            while (input!="buy")
            {
                string[] commands = input.Split().ToArray();
                string item = commands[0];
                double price = double.Parse(commands[1]);
                double quantity = double.Parse(commands[2]);

                if (dict.ContainsKey(item))
                {
                    dict[item][0]=price;
                    dict[item][1]+=quantity;
                }
                else
                {
                    dict.Add(item, new List<double>());
                    dict[item].Add(price);
                    dict[item].Add(quantity);
                }
               
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {

                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }

        }
    }
}
