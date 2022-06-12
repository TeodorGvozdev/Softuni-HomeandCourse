using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] allNumbers = 
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < allNumbers.Length; i++)
            {
                Console.WriteLine($"{allNumbers[i]} => {(int)Math.Round(allNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
