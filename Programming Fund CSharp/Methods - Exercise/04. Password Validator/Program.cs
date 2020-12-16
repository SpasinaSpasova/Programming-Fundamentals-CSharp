using System;
using System.Threading;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            PassValidator(password);
        }

        static void PassValidator(string password)
        {
            bool valid = true;
            if (password.Length < 6 || password.Length >= 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
                valid = false;
            }

            if (CharAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                valid = false;
            }

            if (NumsInPass(password)<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = false;
            }

            if (valid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {

                char current = password[i];
                if (!((current >= 48 && current <= 57) ||
                    (current >= 65 && current <= 90) ||
                    (current >= 97 && current <= 122)))

                {
                    return true;
                }
            }
            return false;

        }

        static int NumsInPass(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
