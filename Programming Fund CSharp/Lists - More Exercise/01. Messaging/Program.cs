using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                 .ToList();

            string text = Console.ReadLine();

            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                string currentElement ="";
                int sum = 0;
                currentElement = numbers[i].ToString();

                for (int j = 0; j < currentElement.Length; j++)
                {
                    sum += int.Parse(currentElement[j].ToString());
                }

                if (sum>text.Length)
                {
                    sum = 1;
                }
                for (int k = 0; k <= text.Length; k++)
                {
                    if (sum==k)
                    {
                        result += text[k];

                        string newMessage = text.Remove(k, 1);
                        text = newMessage;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
