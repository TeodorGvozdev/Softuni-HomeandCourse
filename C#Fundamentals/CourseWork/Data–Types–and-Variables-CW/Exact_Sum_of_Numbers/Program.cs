using System;

namespace Exact_Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < numberCount; i++)
            {
                decimal current = decimal.Parse(Console.ReadLine());
                total += current;
            }
            Console.WriteLine(total);
        }
    }
}
