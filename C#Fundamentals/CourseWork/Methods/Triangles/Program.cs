using System;

namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
        static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int o = 1; o <= i; o++)
                {
                    Console.Write(o + " ");
                }
                Console.WriteLine();
            }
            for (int i = size-1; i > 0; i--)
            {
                for (int o = 1; o <= i; o++)
                {
                    Console.Write(o + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
