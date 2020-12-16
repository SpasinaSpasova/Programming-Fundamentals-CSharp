using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numOfChars = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 1; i <= numOfChars; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int current = character + key;
                result += (char)current;

            }
            Console.WriteLine(result);
        }
    }
}
