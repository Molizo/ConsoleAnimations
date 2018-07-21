using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimations
{
    internal class Program
    {
        private static string[] animations = { "Test 1", "Test 2", "Test 3" };

        private static void Main(string[] args)
        {
            int selection = mainMenu();
            Console.WriteLine("Selected" + selection);
            Console.Read();
        }

        private static int mainMenu()
        {
            int selection = 0;
            //Initializes for display
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            while (true)
            {
                Console.Clear();
                if (selection < 0)
                    selection = animations.Count() - 1;
                else if (selection >= animations.Count())
                    selection = 0;
                for (int i = 0; i < animations.Count(); i++)
                {
                    if (i == selection)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(animations[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                        Console.WriteLine(animations[i]);
                }
            }
        }
    }
}