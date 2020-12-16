using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool check = false;
            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    check = true;
                }
                else if (command[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    List<int> result = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            result.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", result));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<int> result = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            result.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", result));
                }
                else if (command[0] == "GetSum")
                { 
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    if (command[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(command[2]))));
                    }
                    else if (command[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(command[2]))));
                    }
                    else if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(command[2]))));

                    }
                    else if (command[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(command[2]))));

                    }
                }


                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (check)
            {
                Console.WriteLine(string.Join(" ", numbers));

            }
        }
    }

}
