using System;
using System.Linq;

namespace Arrays_CW
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine(numbers.Length);
            numbers[1] = 132;
            numbers[2] = 11;
            numbers[4] = 151;
            numbers[3] = 1111;
            numbers[5] = 142321;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }//typing out an array

            string input = Console.ReadLine();
            string[] manyNumbers = input.Split(' '); // Split will take the original string and split it into seperate strings based on the present spacebars
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // this added code ensures in case of extra empty spaces between input the split will still correctly only take the real values
        
            // Bellow is another method of taking information from one row and then ordering it inside a string array and then converting to an integer array

            var inputLine = Console.ReadLine();
            string[] items = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] arr = items.Select(int.Parse).ToArray();

            // And finally here's the shortest version, directly taking keyboard input, splitting it, parsing into integers and setting into an int array

            int[] array = 
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            // The Join method, allows you to do the reverse of Split, instead you take an already formed array and join it's content into one output

            Console.WriteLine(string.Join("=>", array));

            //Foreach is a method which allows a variable to take on the value of the current element in a collection(array or other)
            // And then that element's value can be used, upon the end of  the foreach, a new cycle starts with the next element in the collection
            // foreach has no way of keeping track on which index inside the collection you currently are, it simply moves along from the first to the last
            int[] things = { 1, 2, 3, 4, 5, 6, 7, };
            foreach (int item in things)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}

