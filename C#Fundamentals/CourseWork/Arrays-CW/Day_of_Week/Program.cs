using System;

namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int weekDay = int.Parse(Console.ReadLine());
            weekDay--;
            if (weekDay < 0 || weekDay > 6)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(week[weekDay]);
            }

        }
    }
}
