using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            if (command=="add")
            {
                result = Add(num1, num2);
            }
            else if (command == "multiply")
            {
                result = Multiply(num1, num2);
            }
            else if (command == "subtract")
            {
                result = Subtract(num1, num2);
            }
            else if (command == "divide")
            {
                result = Divide(num1, num2);
            }
            Console.WriteLine(result);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
