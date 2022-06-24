using System;
using System.Text;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeater(word,repeats));


            StringBuilder result = new StringBuilder();

            result.Append(word);
            Console.WriteLine(result.ToString());

            //The above is StringBuilder type, stringbuilder allows concatenation of multiple
            //strings into one without the need to create a new string each time.
        }
        static string Repeater(string w, int r)
        {
            string newWord = string.Empty;
            for (int i = 0; i < r; i++)
            {
                newWord += w; 
            }
            return newWord;
        }
    }
}
