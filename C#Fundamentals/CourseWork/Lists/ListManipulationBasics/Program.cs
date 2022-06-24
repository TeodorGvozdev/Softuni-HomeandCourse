using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> originalNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> currentCommand = new List<string>();
            List<int> temporary = new List<int>();
            int action = 0, index = 0;
            bool change = false;
            string condition = string.Empty;
            while (true)
            {
                currentCommand = Console.ReadLine().Split(" ").ToList();
                if (currentCommand[0] == "end" && change == true)
                {
                    Console.WriteLine(String.Join(" ", originalNumbers));
                    return;
                }
                else if (currentCommand[0] == "end")
                {
                    return;
                }
                if(currentCommand[0] == "Filter")
                {
                    condition = currentCommand[1];
                    action = int.Parse(currentCommand[2]);
                }
                else if(currentCommand[0] == "PrintEven" || currentCommand[0] == "PrintOdd" || currentCommand[0] == "GetSum")
                {

                }
                else action = int.Parse(currentCommand[1]);
                switch (currentCommand[0])
                {
                    case "Add":
                        originalNumbers.Add(action);
                        change = true;
                        break;
                    case "Remove":
                        originalNumbers.Remove(action);
                        change = true;
                        break;
                    case "RemoveAt":
                        originalNumbers.RemoveAt(action);
                        change = true;
                        break;
                    case "Insert":
                        index = int.Parse(currentCommand[2]);
                        originalNumbers.Insert(index, action);
                        change = true;
                        break;
                    case "Contains":
                        if (originalNumbers.Contains(action))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        foreach (int item in originalNumbers)
                        {
                            temporary.Add(item);
                        }
                        temporary.RemoveAll(uneven => uneven % 2 != 0);
                        Console.WriteLine(String.Join(" ", temporary));
                        break;
                    case "PrintOdd":
                        foreach (int item in originalNumbers)
                        {
                            temporary.Add(item);
                        }
                        temporary.RemoveAll(even => even % 2 == 0);
                        Console.WriteLine(String.Join(" ", temporary));
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach (int current in originalNumbers)
                        {
                            sum += current;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (condition)
                        {
                            case "<":
                                foreach (int current in originalNumbers)
                                {
                                    if (current < action)
                                    {
                                        temporary.Add(current);
                                    }
                                }
                                Console.WriteLine(String.Join(" ", temporary));
                                break;
                            case ">":
                                foreach (int current in originalNumbers)
                                {
                                    if (current > action)
                                    {
                                        temporary.Add(current);
                                    }
                                }
                                Console.WriteLine(String.Join(" ", temporary));
                                break;
                            case "<=":
                                foreach (int current in originalNumbers)
                                {
                                    if (current <= action)
                                    {
                                        temporary.Add(current);
                                    }
                                }
                                Console.WriteLine(String.Join(" ", temporary));
                                break;
                            case ">=":
                                foreach (int current in originalNumbers)
                                {
                                    if (current >= action)
                                    {
                                        temporary.Add(current);
                                    }
                                }
                                Console.WriteLine(String.Join(" ", temporary));
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;

                }
                temporary.Clear();
                currentCommand = new List<string>();
            }
        }
    }
}
