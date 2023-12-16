namespace HelloUniverse;
class HelloUniverse
{
    
    private static void Main(string[] args)
    {
        GetAppInfo();
        GreetUser();

        while (true)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            int guess = 0;

            PrintMessageInColor(ConsoleColor.Cyan, "Guess a number between 1 and 10.");

            while (guess != correctNumber)
            {
                var inputNumber = Console.ReadLine();

                // Make sure it's a number and set to guess var
                if (!int.TryParse(inputNumber, out guess))
                {
                    PrintMessageInColor(ConsoleColor.Red, "Please enter an actual number.");
                    continue;
                }

                // Match guess to correctNumber var
                if (guess != correctNumber)
                    PrintMessageInColor(ConsoleColor.Red, "Wrong number! Please try again.");
            }

            // Tell user it's the right number
            PrintMessageInColor(ConsoleColor.Yellow, "You are correct!");

            // See if user wants to play again
            Console.WriteLine("Play again? [Y or N]?");
            var answer = Console.ReadLine()?.ToUpper();
            if ("Y" == answer) continue;

            return; // If we get here, exit
        }
    }

    /**
     * Get and display app information
     *
     * @return void
     */
    private static void GetAppInfo()
    {
        const string appName = "Number Guesser";
        const string appVersion = "1.0.0";
        const string appAuthor = "Sean Davis";

        // Output app info
        PrintMessageInColor(ConsoleColor.Magenta, $"{appName}: Version {appVersion} by {appAuthor}");
    }

    /**
     * Greet the user and get the name
     *
     * @return void
     */
    private static void GreetUser()
    {
        
        // Get user's name
        Console.WriteLine("What is your name?");
        Console.ForegroundColor = ConsoleColor.Cyan;
        var inputName = Console.ReadLine();
        Console.ResetColor();

        // Greet user by name
        Console.WriteLine($"Hello, {inputName}. Let's play a game...");
    }

    /**
     * Print color message
     *
     * @param ConsoleColor color
     * @param string message
     * 
     * @return void
     */
    private static void PrintMessageInColor(ConsoleColor color, string message)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}