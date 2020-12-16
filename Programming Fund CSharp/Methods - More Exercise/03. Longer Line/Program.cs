using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4= double.Parse(Console.ReadLine());


            double first1 = Math.Abs(x1) + Math.Abs(y1);
            double first2 = Math.Abs(x2) + Math.Abs(y2);
            double firstTotal = first1 + first2;

            double second1 = Math.Abs(x3) + Math.Abs(y3);
            double second2 = Math.Abs(x4) + Math.Abs(y4);
            double secondTotal = second1+second2;

            if (firstTotal>secondTotal)
            {
                double firstcoord = Math.Abs(x1) + Math.Abs(y1);
                double secondcoord = Math.Abs(x2) + Math.Abs(y2);
                if (firstcoord <= secondcoord)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})"); ;
                }
            }
            else
            {
                double firstcoord = Math.Abs(x3) + Math.Abs(y3);
                double secondcoord = Math.Abs(x4) + Math.Abs(y4);
                if (firstcoord <= secondcoord)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})"); ;
                }
            }
        }
    }
}
