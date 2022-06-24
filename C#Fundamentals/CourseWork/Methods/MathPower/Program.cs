using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double floor = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(floor, power));
        }

        static double RaiseToPower (double floor, double power)
        {
            double raisedFloor = floor;
            for (int i = 1; i < power; i++)
            {
                raisedFloor *= floor;
            }
            return raisedFloor;
        }
    }
}
