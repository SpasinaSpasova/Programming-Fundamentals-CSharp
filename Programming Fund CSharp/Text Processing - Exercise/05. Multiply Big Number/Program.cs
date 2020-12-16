using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            
            StringBuilder result = new StringBuilder();

            int multiply = 0;

            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
               multiply = num * int.Parse(input[i].ToString())+multiply;

                
                result.Append(multiply%10);
                multiply /= 10;

            }
            StringBuilder reverse = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reverse.Append(result[i]);
            }
            if (multiply>0)
            {
            Console.Write(multiply);
            Console.Write(reverse);

            }
            else
            {
                Console.WriteLine(reverse);
            }
        }
    }
}
