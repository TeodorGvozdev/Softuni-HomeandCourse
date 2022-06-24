using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fullNumbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            for (int i = fullNumbers.Count-1; i >= 0; i--)
            {
                if(fullNumbers[i] < 0)
                {
                    fullNumbers.RemoveAt(i);
                }
            }
            if(fullNumbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
                fullNumbers.Reverse();
                Console.WriteLine(String.Join(" ", fullNumbers));

        }
    }
}
