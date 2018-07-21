using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This is line 1");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("This is line 2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("   and this is still line 2");

            Console.WriteLine("Press enter to terminate...");
            Console.Read();
        }
    }
}