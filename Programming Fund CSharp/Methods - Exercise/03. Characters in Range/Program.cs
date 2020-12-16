using System;
using System.Threading;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            Result(symbol1, symbol2);
        }

        static void Result(char s1, char s2)
        {
            if (s1 < s2)
            {

                secondBig(s1,s2);

            }
            else
            {
                firstBig(s1,s2);
            }
        }


        static void firstBig(char s1, char s2)
        {


            for (int i = s2 + 1; i < s1; i++)
            {
                Console.Write((char)i + " ");
            }

        }

        static void secondBig(char s1, char s2)
        {

            for (int i = s1 + 1; i < s2; i++)
            {
                Console.Write((char)i + " ");
            }

        }

    }
}
