using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral variables
            byte number1 = 1;
            sbyte number2 = -1;
            int number3 = 65536;

            // Print the integral variables
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            // Char variables
            char star = '\u272D';
            char lucky7 = '\u277C';
            char laoEllipsis = '\u0EAF';

            // Print the char variables
            Console.WriteLine(star);
            Console.WriteLine(lucky7);
            Console.WriteLine(laoEllipsis);

            // Real variables
            float realNumber1 = 6.69f;
            double realNumber2 = 5.57;
            decimal realNumber3 = 9.81m;

            // Print the real variables
            Console.WriteLine(realNumber1);
            Console.WriteLine(realNumber2);
            Console.WriteLine(realNumber3);

            // Boolean variables
            bool isTrue = true;
            bool isFalse = false;

            // Print the bool variables
            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);
        }
    }
}
