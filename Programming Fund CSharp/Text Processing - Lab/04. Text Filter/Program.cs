using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string current = bannedWords[i];
                int len = current.Length;

                for (int j = 0; j < len; j++)
                {
                    string replacement = new string('*', len);
                    text = text.Replace(current, replacement);
                }
            }
            Console.WriteLine(text);
        }
    }
}
