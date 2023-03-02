using System;

namespace Argumentos
{
    /// <summary>
    /// The `Program` class contains the main behavior of the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the program.
        /// </summary>
        /// <param name="args">Command line arguments passed to the program.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Bye World");
            
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
