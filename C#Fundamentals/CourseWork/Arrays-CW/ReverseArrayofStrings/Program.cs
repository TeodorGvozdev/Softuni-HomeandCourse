using System;
using System.Linq;

namespace ReverseArrayofStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allThings = 
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(allThings);
            Console.WriteLine(string.Join(" ", allThings));
        }
    }
}
