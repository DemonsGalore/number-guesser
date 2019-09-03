using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Create a random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string inputNumber = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual message.");

                        // Keep going
                        continue;
                    }

                    // Cast to int and out in guess
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Tell user it is the wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again.");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.DarkYellow, "You are correct!!!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // values
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andreas Stopat";
            string appInfo = $"{appName}: Version {appVersion} by {appAuthor}";

            PrintColorMessage(ConsoleColor.Green, appInfo);
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
