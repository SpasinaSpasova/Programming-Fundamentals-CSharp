using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = Area(width,height);
            Console.WriteLine(result);
        }

        static double Area(double w,double h)
        {
            return w * h;
        }
    }
}
