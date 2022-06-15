using System;
using System.Linq;

namespace ZigZag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] zig = new int[rows];
            int[] zag = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                
                int[] currentzigzag = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i%2==0)
                {
                    zig[i] = currentzigzag[0];
                    zag[i] = currentzigzag[1];
                }
                else
                {
                    zag[i] = currentzigzag[0];
                    zig[i] = currentzigzag[1];
                }
            }
            Console.WriteLine(string.Join(" ", zig));
            Console.WriteLine(string.Join(" ", zag));
        }
    }
}
