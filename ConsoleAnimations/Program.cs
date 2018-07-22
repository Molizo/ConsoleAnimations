using System;
using System.Linq;

namespace ConsoleAnimations
{
    public class MainMenu
    {
        private static string[] animations = { "Random Numbers", "Exit" };

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Console Animations | Main Menu";
                Console.CursorVisible = false;
                int selection = Menu(animations, "Console Animations");
                Console.Title = "Console Animations | " + animations[selection];
                switch (animations[selection])
                {
                    case "Random Numbers":
                        RandomNumbers.Show();
                        break;

                    case "Exit":
                        break;

                    default:
                        Console.WriteLine("\n\nAn error has occured.\nPress any key to terminate...");
                        Console.Read();
                        break;
                }
            }
        }

        private static int Menu(string[] options, string title = "")
        {
            /// <summary>This method displays a menu to the user
            /// <para>The method returns an integer based on the user's selection</para>
            /// <param name="options">Used to indicate menu options.</param>
            /// <param name="title">Used to indicate menu title.</param>
            /// </summary>

            int selection = 0;

            //Initializes console window
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

        //Displays the menu to the user
        menuDisplay:
            {
                Console.Clear();

                //Displays the title
                if (title != string.Empty)
                {
                    Console.Write("  ");
                    for (int i = 0; i < title.Length + 4; i++)
                        Console.Write("▄");
                    Console.WriteLine(System.Environment.NewLine + "  █ " + title + " █");
                    Console.Write("  ");
                    for (int i = 0; i < title.Length + 4; i++)
                        Console.Write("▀");
                }
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