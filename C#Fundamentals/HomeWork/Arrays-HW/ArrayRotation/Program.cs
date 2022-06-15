using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] currentNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] afterRotation = new int[currentNums.Length];

            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                for (int o = 0; o < currentNums.Length; o++)
                {
                    if (i%2==0)
                    {
                        if (o+1==currentNums.Length)
                        {
                            afterRotation[o] = currentNums[0];
                        }
                        else
                        {
                            afterRotation[o] = currentNums[o + 1];
                        }
                    }
                    else
                    {
                        if (o + 1 == currentNums.Length)
                        {
                            currentNums[o] = afterRotation[0];
                        }
                        else
                        {
                            currentNums[o] = afterRotation[o + 1];
                        }
                    }
                }
            }
            if (rotations % 2 == 0)
            {
                Console.WriteLine(String.Join(" ", currentNums));
            }
            else
            {
                Console.WriteLine(String.Join(" ", afterRotation));
            }
        
        }
    }
}
