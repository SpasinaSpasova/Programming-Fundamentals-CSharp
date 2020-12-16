using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] cmdArg = input.Split(" | ");
                    string forceSide = cmdArg[0];
                    string forceUser = cmdArg[1];


                    if (!dict.ContainsKey(forceSide))
                    {
                        dict[forceSide] = new List<string>();
                    }

                    if (!dict.Any(x => x.Value.Contains(forceUser)))
                    {
                        dict[forceSide].Add(forceUser);
                    }


                }
                else if (input.Contains('-'))
                {
                    string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string forceUser = cmdArgs[0];
                    string forceSide = cmdArgs[1];

                    foreach (var kvp in dict)
                    {
                        if (kvp.Value.Contains(forceUser))
                        {
                            kvp.Value.Remove(forceUser);
                        }

                    }

                    if (!dict.ContainsKey(forceSide))
                    {
                        dict[forceSide] = new List<string>();
                    }

                    dict[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                }

                input = Console.ReadLine();
            }

            dict = dict
               .Where(s => s.Value.Count > 0)
               .OrderByDescending(s => s.Value.Count)
               .ThenBy(s => s.Key)
               .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                foreach (var item in kvp.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}