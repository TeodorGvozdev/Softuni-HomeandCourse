using System;

namespace Integer_and_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000f;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
