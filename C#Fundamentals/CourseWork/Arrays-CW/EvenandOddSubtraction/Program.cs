using System;
using System.Linq;

namespace EvenandOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fullNumInput =
            Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            int sumOfEvensvsOdd = 0;
            

            foreach (int item in fullNumInput)
            {
                if (item % 2 == 0)
                {
                    sumOfEvensvsOdd += item;
                }
                else
                {
                    sumOfEvensvsOdd -= item;
                }
            }
            Console.WriteLine(sumOfEvensvsOdd);
        }
    }
}
