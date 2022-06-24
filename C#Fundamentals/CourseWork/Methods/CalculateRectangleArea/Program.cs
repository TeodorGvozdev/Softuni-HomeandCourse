using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));

        }
        static double Area(double w, double h)
        {
            return w* h;
        }
    }
}
