using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            

            if (command == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{ReturnInt(input1,input2)}");
            }
            else if (command=="char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());

                Console.WriteLine($"{ReturnChar(input1, input2)}");
            }
            else if (command == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();

                Console.WriteLine($"{ReturnString(input1, input2)}");
            }

        }

        static int ReturnInt(int num1,int num2)
        {

          return  Math.Max(num1, num2);
            
        }

        static char ReturnChar(char ch1, char ch2)
        {
            if (ch1>=ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
            

        }

        static string ReturnString(string str1,string str2)
        {
            if (str1.CompareTo(str2)>=0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }


    }
}

