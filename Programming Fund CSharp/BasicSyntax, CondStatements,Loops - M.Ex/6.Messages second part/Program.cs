using System;

namespace _6.Messages_second_part
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());//5
            string output = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                string digits = Console.ReadLine();//44

                int countOfDigist = digits.Length;//2

                string mainDigits = digits[0].ToString();//"2"

                int offset = (int.Parse(mainDigits) - 2) * 3;
                               //2
                if (int.Parse(mainDigits)==0)//za interval
                {
                    output += (char)(int.Parse(mainDigits) + 32);
                    continue;
                }
                if (int.Parse(mainDigits)==8|| int.Parse(mainDigits) == 9)//zashtoto 7 i 8 imat 4 simvola
                {
                    offset++;
                }
                int letterIndex = (offset + countOfDigist - 1);
                output += (char)(letterIndex + 97);
            }
            Console.WriteLine(output);
        }
    }
}
