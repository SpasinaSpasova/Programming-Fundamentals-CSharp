using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{Result(input)}");
        }

        static int Result(string input)
        {
            int sum = 0; 

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString()=="a"||
                    input[i].ToString() == "e" ||
                    input[i].ToString() == "i" ||
                    input[i].ToString() == "u" ||
                    input[i].ToString() == "o" ||
                    input[i].ToString() == "A" ||
                    input[i].ToString() == "E" ||
                    input[i].ToString() == "I" ||
                    input[i].ToString() == "O" ||
                    input[i].ToString() == "U" )
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
