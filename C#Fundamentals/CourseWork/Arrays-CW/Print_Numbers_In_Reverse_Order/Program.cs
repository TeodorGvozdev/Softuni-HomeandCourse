using System;

namespace Print_Numbers_In_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] allNumbers = new int[length];
            for (int i = length-1; i >= 0; i--)
            {
                allNumbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(allNumbers[i] + " ");
            }
        }
    }
}
