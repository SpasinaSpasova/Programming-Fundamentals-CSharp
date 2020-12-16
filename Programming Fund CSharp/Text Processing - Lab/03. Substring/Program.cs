using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string theLine = Console.ReadLine().ToLower();

            int index = theLine.IndexOf(word);

            while (index>=0)
            {
        
                theLine=theLine.Remove(index, word.Length);
                index = theLine.IndexOf(word);
            }
            Console.WriteLine(theLine);
        }
    }
}
