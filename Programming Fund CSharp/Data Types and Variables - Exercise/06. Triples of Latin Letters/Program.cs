using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            for (char i = (char)97; i < (char)97+n; i++)
            {
                for (char j = (char)97; j < (char)97+n ; j++)
                {
                    for (char k = (char)97; k < (char)97 +n; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
