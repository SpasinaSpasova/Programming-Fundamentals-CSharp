using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string activity = input[0];
                string user = input[1];

                if (activity == "register")
                {
                    string licensePlateNumber = input[2];
                    if (dict.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[user]}");
                    }
                    else
                    {
                        dict.Add(user, licensePlateNumber);
                        Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                    }
                }
                else if (activity == "unregister")
                {
                    if (dict.ContainsKey(user))
                    {

                        dict.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
