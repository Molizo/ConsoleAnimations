using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimations
{
    internal class Program
    {
        private static string[] animations = { "Test 1", "Test 2", "Test 3", "Test4", "Test555555555555", "Test283" };

        private static void Main(string[] args)
        {
            Console.Title = "Console Animations";
            Console.CursorVisible = false;
            int selection = menu(animations, "Console Animations");

            Console.WriteLine("Selected " + animations[selection]);
            Console.Read();
        }

        private static int menu(string[] options, string title)
        {
            int selection = 0;

            //Initializes console window
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        //Displays the menu to the user
        menuDisplay:
            {
                Console.Clear();

                //Displays the title
                for (int i = 0; i < title.Length + 4; i++)
                    Console.Write("▄");
                Console.WriteLine(System.Environment.NewLine + "█ " + title + " █");
                for (int i = 0; i < title.Length + 4; i++)
                    Console.Write("▀");
                Console.WriteLine();

                for (int i = 0; i < animations.Count(); i++)
                {
                    Console.Write("  "); //Adds space before the text so that it looks better
                    if (i == selection)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine(options[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                        Console.WriteLine(options[i]);
                }
                System.Threading.Thread.Sleep(10);
            }
            while (true)
            {
                //Redraws the menu only if a key is pressed
                if (Console.KeyAvailable)
                {
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

                    //Check for over- or underflows of the selected item variable
                    if (selection < 0)
                        selection = options.Count() - 1;
                    else if (selection >= options.Count())
                        selection = 0;
                    goto menuDisplay;
                }
            }
        }
    }
}