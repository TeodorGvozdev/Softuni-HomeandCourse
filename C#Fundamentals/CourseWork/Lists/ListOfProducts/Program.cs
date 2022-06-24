using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                listOfProducts.Add(Console.ReadLine());

            }
            listOfProducts.Sort();
            int current = 1;
            foreach (string item in listOfProducts)
            {
                Console.WriteLine($"{current}.{item}");
                current++;
            }
        }
    }
}
