using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            while (input != "End")
            {
                string[] cmdArg = input.Split(" -> ");

                string company = cmdArg[0];
                string id = cmdArg[1];
                if (dict.ContainsKey(company))
                {
                    List<string> check = dict[company];

                    if (!check.Contains(id))
                    {
                        dict[company].Add(id);
                    }

                }
                else
                {
                    dict.Add(company, new List<string> { id });
                }


                input = Console.ReadLine();
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
