using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "3:1")
            {

                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);

                string result = string.Empty;
                if (startIndex<0||startIndex>input.Count-1)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }
                if (command[0]=="merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result += input[i];
                    }
                    input.RemoveRange(startIndex,endIndex-startIndex+1);
                    input.Insert(startIndex, result);
                }
                else if (command[0]=="divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    string word = input[index];
                    input.RemoveAt(index);
                    int lenghtOfParts = word.Length / partitions;

                    List<string> output = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i==partitions-1)
                        {
                            output.Add(word.Substring(i * lenghtOfParts));
                        }
                        else
                        {
                            output.Add(word.Substring(i * lenghtOfParts,lenghtOfParts));
                        }
                    }
                    input.InsertRange(index, output);


                }


                command = Console.ReadLine().Split().ToArray();

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
