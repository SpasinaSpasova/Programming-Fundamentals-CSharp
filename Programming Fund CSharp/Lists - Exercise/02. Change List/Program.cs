using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

            while (commnad[0] != "end")
            {

                if (commnad[0]=="Delete")
                {
                    int num = int.Parse(commnad[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]==num)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                }
                else if (commnad[0] == "Insert")
                {
                    int numToInsert = int.Parse(commnad[1]);
                    int index = int.Parse(commnad[2]);

                    numbers.Insert(index,numToInsert);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
