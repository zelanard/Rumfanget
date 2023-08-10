using System;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            float h, b, l;

            //make sure the program can run more than once.
            while (true)
            {
                //prompt the user for height.
                Console.Write("Please write the height here: ");
                h = float.Parse(Console.ReadLine());

                //prompt the user for a width.
                Console.Write("Please write the width here: ");
                b = float.Parse(Console.ReadLine());

                //prompt the uesr for a length.
                Console.Write("Please write the length here: ");
                l = float.Parse(Console.ReadLine());

                //write the volume of Box
                Console.WriteLine("The Volumne of your box is: " + BoxVol(h, b, l));
                Console.WriteLine(); //Make an empty line

                //prompt the user to either press enter or escape to run the app again or close it.
                Console.WriteLine("Press Enter to calculate the Volumne of a new Box.");
                Console.WriteLine("Press Escape to close the App.");
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.Enter)
                {
                    //if the enter key was pressed, clear the console, the app will run keep running in the while loop.
                    Console.Clear();
                }
                else if (key == ConsoleKey.Escape)
                {
                    //if escape was pressed the while loop will terminate.
                    break;
                }
            }
        }

        /// <param name="h"></param>
        /// <param name="b"></param>
        /// <param name="l"></param>
        /// <returns>The volumne of the Box</returns>
        private static float BoxVol(float h, float b, float l)
        {
            return h * b * l;
        }
    }
}