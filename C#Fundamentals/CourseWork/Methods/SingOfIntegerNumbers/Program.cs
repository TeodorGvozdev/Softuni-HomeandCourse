using System;

namespace SingOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SignofNumber(int.Parse(Console.ReadLine()));
        }
        static void SignofNumber(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
