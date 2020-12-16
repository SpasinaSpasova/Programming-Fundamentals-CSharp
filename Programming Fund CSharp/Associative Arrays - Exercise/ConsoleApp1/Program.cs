using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello hello";
            char[] ch = str.ToCharArray();

            
                Console.WriteLine(string.Join("",ch.Where(x=>x!='o')));
        }
    }
}
