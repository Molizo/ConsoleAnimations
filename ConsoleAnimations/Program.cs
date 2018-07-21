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
            Console.WriteLine("Selected " + animations[selection]);
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
                //Redraws the menu only if a key is pressed
                if (Console.KeyAvailable)
                {
                    Console.Clear();

                    //Gets the inputted key
                    ConsoleKey inputKey = new ConsoleKey();
                    inputKey = Console.ReadKey(true).Key;

                    //Decides what to do
                    switch (inputKey)
                    {
                        case ConsoleKey.UpArrow:
                            selection--;
                            break;

                        case ConsoleKey.DownArrow:
                            selection++;
                            break;

                        case ConsoleKey.Enter:
                            return selection;
                    }

                    //Check for over or underflows of the selected item variable
                    if (selection < 0)
                        selection = animations.Count() - 1;
                    else if (selection >= animations.Count())
                        selection = 0;

                    //Displays the menu to the user
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
}