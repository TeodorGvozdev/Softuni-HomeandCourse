using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> allNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> afterMerge = new List<int>();
            while(allNums.Count > 1)
            {
                afterMerge.Add(allNums[0] + allNums[allNums.Count - 1]);
                allNums.RemoveAt(0);
                allNums.RemoveAt(allNums.Count -1);

            }
            if(allNums.Count > 0)
            {
                afterMerge.Add(allNums[0]);
            }
            Console.WriteLine(String.Join(" ", afterMerge));

        }
    }
}
