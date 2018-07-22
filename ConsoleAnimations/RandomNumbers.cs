using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimations
{
    public class RandomNumbers
    {
        public static void Show()
        {
            bool exit = false;
            Console.Clear();
            Random rand = new Random();
            while (exit == false)
            {
                for (int i = 0; i < Console.WindowHeight - 1; i++)
                {
                    string rowNumbers = String.Empty; ///This string contains a row full of numbers.
                                                      ///This is done so that the last row wouldn't look half empty
                                                      ///if the code was generating and outputting them one by one.
                    while (rowNumbers.Length <= Console.WindowWidth)
                        rowNumbers += rand.Next().ToString();
                    Console.Write(rowNumbers.Remove(Console.WindowWidth)); //Displays only a row full of numbers,no more than that.
                    System.Threading.Thread.Sleep(50);
                }
                if (Console.KeyAvailable)
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape: //Exit on user request
                            Console.Write("\n\n Do you want to return to the main menu? (Yes/No) : ");
                            if (Console.ReadLine().ToString().ToLower().Contains("y"))
                                exit = true;
                            break;
                    }
            }
        }
    }
}