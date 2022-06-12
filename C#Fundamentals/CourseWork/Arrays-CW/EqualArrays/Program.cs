using System;
using System.Linq;

namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fArray =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).
                ToArray();
            int[] sArray =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool identical = true;
            int difference = 0;
            int sumOfArray = 0;

            for (int i = 0; i < fArray.Length; i++)
            {
                if (fArray[i]==sArray[i])
                {
                    sumOfArray += fArray[i];
                }
                else
                {
                    identical = false;
                    difference = i;
                    break;
                }
            }
            if (identical == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {difference} index.");
            }
        }
    }
}
