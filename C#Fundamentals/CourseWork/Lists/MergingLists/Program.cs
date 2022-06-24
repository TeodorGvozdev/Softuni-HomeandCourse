using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();
            List<int> finalNumbers = new List<int>();

            finalNumbers.AddRange(Merger(firstNumbers, secondNumbers));
            Console.WriteLine(string.Join(" ", finalNumbers));

        }
        public static List<int> Merger(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();
            if (first.Count > second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (second.Count > i)
                    {
                        result.Add(first[i]);
                        result.Add(second[i]);
                    }
                    else result.Add(first[i]);
                }

            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    if (first.Count > i)
                    {
                        result.Add(first[i]);
                        result.Add(second[i]);
                    }
                    else result.Add(second[i]);
                }
            }
            return result;
        }
    }
}
