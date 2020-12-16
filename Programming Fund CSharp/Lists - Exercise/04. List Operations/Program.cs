using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commnad = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commnad[0] != "End")
            {
                if (commnad[0] == "Add")
                {
                    numbers.Add(int.Parse(commnad[1]));

                }
                else if (commnad[0] == "Insert")
                {
                    int numToInsert = int.Parse(commnad[1]);
                    int index = int.Parse(commnad[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, numToInsert);

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commnad[0] == "Remove")
                {

                    int index = int.Parse(commnad[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                   
                }
                else if (commnad[0] == "Shift")
                {
                    int count = int.Parse(commnad[2]);

                    if (commnad[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int first = numbers[0];
                            numbers.Add(first);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (commnad[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int last = numbers[numbers.Count - 1];
                            numbers.Insert(0, last);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }


                commnad = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
