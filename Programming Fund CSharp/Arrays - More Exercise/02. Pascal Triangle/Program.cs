using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            int[] theZero = new int[1];
            theZero[0] = 1;
            while (theZero.Length <= count)
            {
                Console.WriteLine(string.Join(" ", theZero));

                int[] theNext = new int[theZero.Length + 1];
                theNext[0] = 1;
                theNext[theNext.Length - 1] = 1;



                if (theZero.Length > 1)
                {
                    for (int i = 1; i < theNext.Length-1; i++)
                    {
                        theNext[i] = theZero[i - 1] + theZero[i];
                    }
                }

                theZero = theNext;
            }
        }
    }
}
