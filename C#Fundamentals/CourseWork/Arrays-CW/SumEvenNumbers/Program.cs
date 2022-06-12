using System;
using System.Linq;

namespace SumEvenNumbers
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
            int sumOfEvens = 0;

            foreach (int item in fullNumInput)
            {
                if (item % 2 == 0)
                {
                    sumOfEvens += item;
                }
            }
            Console.WriteLine(sumOfEvens);
        }
    }
}
