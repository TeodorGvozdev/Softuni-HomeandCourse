using System;
using System.Linq;

namespace Arrays_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];
            int allPassengers = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                allPassengers+=wagons[i];
            }
            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(allPassengers);
            
            //int[] wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        }
    }
}
