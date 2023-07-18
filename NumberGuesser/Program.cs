
GetAppInfo();

GreetUser(); 

while (true) {
    //Create a new Random number
    Random random = new Random();

    int correctNumber = random.Next(1, 10);

    // Init guess var
    int guess = 0;

    //Ask user for number
    Console.WriteLine("Guess a number between 1 and 10");

    while (guess != correctNumber) {
        // Get users input
        string? input = Console.ReadLine();

        //Cast to int and put in guess
        if (input != null) {

            //Make sure it is a number
            if (!int.TryParse(input, out guess)) {
              PrintColorMessage(ConsoleColor.Red, "This is not a number, try again!");
                continue;
            }

            guess = Int32.Parse(input);
        }

        //Match guess to correct number
        if (guess != correctNumber) {
           PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again!");
        }
    }

    // If it is correct  

    PrintColorMessage(ConsoleColor.DarkBlue, "Great! You have found it!");

    //Ask to play again
    Console.WriteLine("Play Again? [Y or any]");

    string answer = Console.ReadLine().ToUpper();

    if (answer != null) {
        if (answer == "Y") {
            continue;
        }
        else {
            return;
        }
    }
}

// Functions
static void GetAppInfo()
{
    // Set app vars
    string appName = "Number Guesser";
    string appVersion = "1.0.0.";
    string appAuthor = "Ali Gok";

    // Change text color
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    //Write out app info
    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

    //Reset text color
    Console.ResetColor();
}

static void GreetUser()
{
    //Ask users name
    Console.WriteLine("What is your name?");

    //Get user input
    string? inputName = Console.ReadLine();

    Console.WriteLine("Hello {0}, let's play a game...", inputName);
}

static void PrintColorMessage(ConsoleColor color, string message)
{
    //Change text color
    Console.ForegroundColor = color;

    //Tell user it is a a number
    Console.WriteLine(message);

    //Reset text color
    Console.ResetColor();
}