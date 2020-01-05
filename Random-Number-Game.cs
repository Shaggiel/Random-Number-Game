//shameless plug == check out shaggielprograms on youtube for more "high quality" mainly for kids content, with medium amounts of gaming and coding tutorials like and sub all videos ty.

using System;

namespace Random_Number-Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Random Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Shaggiel";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
            
            Random rnd = new Random();

            Console.WriteLine("Guess a number between 1 and 10 please.");

            int guess = 0;

            int correctNumber = rnd.Next(1, 10);

            while (guess != correctNumber) {
                string input = Console.ReadLine();

                guess = Int32.Parse(input);
                if (guess != correctNumber) {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Incorrect Number, Please Try Again.");
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You Guessed Correct! The Correct Number Was {0}! Let's Give {1} a Round Of A Plause!", correctNumber, inputName);
                    Console.WriteLine("Do You Wish To Play Again? [Y (for yes) N (for no)]");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y") {
                        Console.WriteLine("YAYYYYY {0}, JUST YAYYYYYYY", inputName);
                        continue;
                    } else if (answer == "N") {
                        Console.WriteLine("Ok, I understand {0} :(", inputName);
                        return;
                    } else {
                        return;
                    }
                }
            }

            
        }
    }
}
