using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            list<string> list = new list<string>();
            list.add("teo");
            list.add("polly");
            list.add("ivan");
            //above showcases creation and adding of elements into a list
            foreach (string name in list)
            {
                console.writeline(name);
            }

            //foreach allows us to move through the list
            console.writeline(string.join(',', list));

            list.insert(2, "zigi");
            //allows us to insert an element anywhere within the list, the list is re-arranged to fit it inside

            list.remove("ivan");
            //allows removal of an element from the list

            console.writeline("no more ivan, now there's zigi!");

            if (list.contains("zigi"))
            {
                console.writeline("yes!!! we have the cat");
            }
            //contains returns a boolean value depending if the element searched for is inside the list

            list.sort();
            //sort sorts the list in ascending order
            console.writeline("bellow is family");
            console.writeline(string.join("loves", list));


            list<int> numbers = new list<int> { 1, 2, 3, 4, 5 };
            numbers.reverse();
            //reverse turns around the list
            console.writeline(string.join(", ", numbers));

            //the bellow code, takes numbers from a single line as a string and converts them to a list of integers

            string initialValues = Console.ReadLine();
            List<string> values = initialValues.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> realValues = new List<int>();
            foreach (string current in values)
            {
                realValues.Add(int.Parse(current));
            }

            Console.WriteLine(string.Join(" ", realValues));

            // Bellow is a short version of the above actions, directly reading a single line of input and converting it into a list of integers

            List<int> quickNumbers = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToList();



            
        }
    }
}
