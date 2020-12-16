using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int openScobe = 0;
            int closeScobe = 0;

            string lastInput = "";


            for (int i = 1; i <= count; i++)
            {
                string input = Console.ReadLine();
                string currentInput = input;
                if (input == "(")
                {
                    if (currentInput != lastInput)
                    {
                        lastInput = currentInput;
                        openScobe++;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input == ")")
                {
                    if (currentInput != lastInput)
                    {
                        lastInput = currentInput;
                        closeScobe++;

                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (openScobe == closeScobe)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
