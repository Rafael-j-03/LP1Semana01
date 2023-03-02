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


            int x = 5;
            int y = 3;
            // Concatenation of strings
            string s7 = "a" + "b" + "c" + "=" + "abc";
            string s8 = "a" + x;
            
            // Interpolation of strings
            string s9 = $"The x value is: {x}";
            string s10 = $"x + y is equal to: {x + y}";

            // String formats
            string s11 = String.Format("x is {0} and y {1}", x, y);
            string s12 = String.Format("x is {1} and y {0}", 1, -2);

            // Print all of the new strings
            Console.WriteLine(s7);
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);

            // String formats in console writing
            Console.WriteLine("z value is {0}", 3);
            Console.WriteLine(@"Verbatim x value is {0}", x);
        }
    }
}
