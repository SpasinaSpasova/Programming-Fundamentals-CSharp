using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<string, char[]> dict = new Dictionary<string, char[]>();


            while (word!="end")
            {
                string reverse = new string(word.Reverse().ToArray());
                dict.Add(word, reverse.ToCharArray());

                word = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {string.Join("",item.Value)}");
            }
        }
    }
}
