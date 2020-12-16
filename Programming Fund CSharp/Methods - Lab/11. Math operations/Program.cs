using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;
            if (command=="+")
            {
                result = Add(num1, num2);
            }
            else if (command == "-")
            {
                result = Izvajdane(num1, num2);
            }
            else if (command == "*")
            {
                result = Multiply(num1, num2);
            }
            else if (command == "/")
            {
                result = Divide(num1, num2);
            }
            Console.WriteLine($"{Math.Round(result,2)}");
        }

        static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Izvajdane(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
