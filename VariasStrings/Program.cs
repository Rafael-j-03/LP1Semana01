using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variables
            string s1 = "Hello World \u2605";
            string s2 = @"Hello World \u2605";
            string s3 = "This\t is\t a\t test\t \u00A9";
            string s4 = @"This\t is\t a\t test\t \u00A9";
            string s5 = "C:\\Users\\Rafael\\Downloads";
            string s6 = @"C:\Users\Rafael\Downloads";

            // Print the string variables
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
        }
    }
}
