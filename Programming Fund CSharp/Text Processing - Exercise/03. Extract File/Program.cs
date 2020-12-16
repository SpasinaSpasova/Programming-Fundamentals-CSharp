using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string[] theInfo = line[line.Length - 1].Split(".").ToArray();

            Console.WriteLine($"File name: {theInfo[0]}");
            Console.WriteLine($"File extension: {theInfo[1]}");
        }
    }
}
