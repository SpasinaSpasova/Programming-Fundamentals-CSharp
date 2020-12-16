using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string startInput = Console.ReadLine().ToLower();
            string[] input = startInput
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> theMain = new Dictionary<string, int>()
            {
                { "shards",0},
                { "fragments",0},
                { "motes",0}
            };

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            bool forWhile = false;
            while (true)
            {


                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];

                    if (theMain.ContainsKey(item))
                    {
                        theMain[item] += quantity;

                        if (theMain[item] >= 250 &&
                            item == "shards")
                        {
                            theMain[item] -= 250;

                            Console.WriteLine("Shadowmourne obtained!");
                            forWhile = true;
                            break;
                        }
                        else if (theMain[item] >= 250 &&
                                 item == "fragments")
                        {
                            theMain[item] -= 250;

                            Console.WriteLine("Valanyr obtained!");
                            forWhile = true;

                            break;
                        }
                        else if (theMain[item] >= 250 &&
                                 item == "motes")
                        {
                            theMain[item] -= 250;

                            Console.WriteLine("Dragonwrath obtained!");
                            forWhile = true;

                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(item))
                        {
                            junk[item] += quantity;
                        }
                        else
                        {
                            junk.Add(item, quantity);

                        }
                    }
                }
                if (forWhile)
                {
                    break;
                }
                startInput = Console.ReadLine().ToLower();
                input = startInput
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            foreach (var item in theMain.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {

                Console.WriteLine($"{item.Key}: {item.Value}");

            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
