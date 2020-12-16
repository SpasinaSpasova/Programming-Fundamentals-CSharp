using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            if (input == "int")
            {
                int num = int.Parse(command);
                Console.WriteLine(MyMethod(num));
            }
            else if (input == "real")
            {
                double num = double.Parse(command);
                Console.WriteLine($"{MyMethod(num):f2}");
            }
            else if (input == "string")
            {
                Console.WriteLine(MyMethod(command));
            }
        }
        static int MyMethod(int x)
        {
            return x * 2;
        }

        static double MyMethod(double x)
        {
            return x * 1.5;
        }

        static string MyMethod(string x)
        {
            string result = "$" + x + "$";
            return result;
        }
    }
}
