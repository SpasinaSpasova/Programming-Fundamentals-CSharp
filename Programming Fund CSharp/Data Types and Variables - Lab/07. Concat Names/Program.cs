using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string theConcat = Console.ReadLine();
            //ne trqbwa da e s if-proverka zashtoto moje da poluchim i drugi znaci
            Console.WriteLine($"{name1}{theConcat}{name2}");

        }
    }
}
