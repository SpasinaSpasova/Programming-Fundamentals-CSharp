using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string correct = string.Empty;
            int count = 1;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                correct += username[i];
            }

            while (password != correct)
            {
                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                count++;


            }
            if (password == correct)
            {
                Console.WriteLine($"User {username} logged in.");

            }
        }
    }
}
