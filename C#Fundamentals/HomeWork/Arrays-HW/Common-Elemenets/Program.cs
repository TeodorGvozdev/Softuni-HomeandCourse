using System;

namespace Common_Elemenets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string currentSecond in secondRow)
            {
                foreach (string currentFirst in firstRow)
                {
                    if (currentSecond == currentFirst)
                    {
                        Console.Write(currentSecond + " ");
                        break;
                    }
                }
            }
        }
    }
}
