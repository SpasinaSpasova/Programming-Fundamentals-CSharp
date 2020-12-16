using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int random = rnd.Next(0, words.Length);
                string current = words[i];
                words[i] = words[random];
                words[random] = current;

            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
