using System;
using System.Xml.Schema;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());//2
            int n2 = int.Parse(Console.ReadLine());//1
            int n3 = int.Parse(Console.ReadLine());//3

            int minimum = Math.Min(n1, Math.Min(n2, n3));//1
            int maximum = Math.Max(n1, Math.Max(n2, n3));//3

            Console.WriteLine(maximum);


            if (n1 >= n2 && n1 <= n3)
            {
                Console.WriteLine(n1);
            }
            if (n2 > n1 && n2 <= n3)
            {
                Console.WriteLine(n2);
            }
            if (n2 < n1 && n2 >= n3)
            {
                Console.WriteLine(n2);
            }
            if (n3 > n2 && n3 <= n1)
            {
                Console.WriteLine(n3);
            }
            if (n1 > n3 && n1 <= n2)
            {
                Console.WriteLine(n1);
            }
            if (n3 < n2 && n3 >= n1)
            {
                Console.WriteLine(n3);
            }


            Console.WriteLine(minimum);

        }
    }
}
