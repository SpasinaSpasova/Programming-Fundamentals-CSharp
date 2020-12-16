using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numStr = num.ToString();
            int sum = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                int current = num % 10;
                num /= 10;
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}
