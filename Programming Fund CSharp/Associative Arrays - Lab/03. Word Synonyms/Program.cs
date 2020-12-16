using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> theResult = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (theResult.ContainsKey(word))
                {
                    theResult[word].Add(synonim);

                }
                else
                {
                    theResult.Add(word, new List<string>());
                    theResult[word].Add(synonim);
                }
            }
            foreach (var item in theResult)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
