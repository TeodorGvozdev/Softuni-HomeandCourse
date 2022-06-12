using System;
using System.Linq;

namespace CondenceArraytoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialNums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            for (int i = initialNums.Length - 1; i >= 1; i--)
            {
                for (int o = 0; o < i; o++)
                {
                    initialNums[o] += initialNums[o + 1];
                }
            }
            Console.WriteLine(initialNums[0]);


        }
    }
}
