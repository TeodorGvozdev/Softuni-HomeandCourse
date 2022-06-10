using System;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FirstName = "Teodor"; // const variables do not follow camelCase and should be written with a capital letter first
            string lastName = Console.ReadLine(); // camelcase is always used for variable naming, if it's only a Noun, no capital letter, if its a Adjective + Noun, the Noun has a capital letter
            Console.WriteLine(FirstName + lastName);

            int otherNumber = 2;

            if (true)
            {
                int number = 0;
            }

            number = 5; // We can not do this as each variable has a "scope" as 'number' was created inside the "if" it can not be used outside of it
            otherNumber = 1; // This is fine as the variable was created inside the Main

            byte max = 0;
            for (int i = 0; i < 260; i++)
            {
                max++;
                Console.WriteLine(max);
            }
            // The above is an example of integer overflow, we filled an integer type, more specifically "byte" with values above it's accepted  maximum, which will lead to incorrect values

            int o = 2_000_000; //When you have larger numbers you can insert "_" for visibility between each 3 numbers, this doesn't affect in anyway the number

            int p = 0xAAFE; // When we set "0x" at the start of a number, this is a literal that says to the Console "this is a hexidecimal number"
            int normal = 1000; //By default the numbers we write are set with literals "int 32" meaning standard 32bit int
            long longer = 15000l; // the "l" literal changes a number to a "Long 64bit"
            float floatPI = 3.141111231232131234f;//"f" literal moves the number to be under float type
            double doublePI = 3.141111231232131234;// the default floating number literal is "double"
            Console.WriteLine("Float PI is : {0}", floatPI);
            Console.WriteLine("Double PI is : {0}", doublePI);
            // The above example showcaes that float is less precise as it won't be able to display all the decimals after the pointer


        }   
    }
}
