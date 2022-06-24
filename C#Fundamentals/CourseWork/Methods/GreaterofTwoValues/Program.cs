using System;

namespace GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "int":
                    int f = int.Parse(Console.ReadLine());
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(f,s));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    Console.WriteLine(GetMax(first, second));
                    break;
                default:
                    break;
            }
            
        }
        static int GetMax(int f, int s)
        {
            if (f > s)
            {
                return f;
            }
            else return s;
        }
        static char GetMax(char f, char s)
        {
            if (f > s)
            {
                return f;
            }
            else return s;
        }
        static string GetMax(string f, string s)
        {
            int result = String.Compare(f, s);
            if (result > 0)
            {
                return f;
            }
            else return s;
        }
    }
}
