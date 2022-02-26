// set app vars

string AppName = "Number Guesser";
string AppVersion = "1.0.0";
string Author = "Kabelo Maswanganye"; 

// Change text colour
Console.ForegroundColor = ConsoleColor.Green;

// Write out app info

Console.WriteLine("{0}: Versions {1} by {2}", AppName, AppVersion, Author);

// Reset colour back to default
Console.ResetColor();

//Ask users name
Console.WriteLine("What is your name?");

// Get user input
string inputName = Console.ReadLine();

Console.WriteLine("Hello {0}, let's play a game...", inputName);

while (true)
{



// Create new random object
Random random = new Random();

// Init correct number
int correctNumber = random.Next(1, 10);

// Initialise guess var
int guess = 0;

// Ask user for number
Console.WriteLine("Guess a number between 1 and 10");

// While guess is incorrect
while (guess != correctNumber)
{
// Get user input
string input = Console.ReadLine();

    // Make sure its a number
    if(!int.TryParse(input, out guess))
    {
        //Change text colour
        Console.ForegroundColor = ConsoleColor.Red;

        // tell user its not a number
        Console.WriteLine("Please enter an actual number");

        // Reset text colour
        Console.ResetColor();

        // Keep going
        continue;
    }

    // Cast to int and put in guess var
    guess = Int32.Parse(input);

    // Match guess to correct number
    if(guess != correctNumber)
    {
        //Change text colour
        Console.ForegroundColor= ConsoleColor.Red;

        // Write out error message
        Console.WriteLine("Wrong number, please try again");

        // Reset text colour
        Console.ResetColor();
        
    }
}

// Output success message
//Change text colour
Console.ForegroundColor = ConsoleColor.Yellow;

// Write out success message
Console.WriteLine("Yay. You are CORRECT");

// Reset text colour
Console.ResetColor();

// Ask to play again
Console.WriteLine("Play again? [Y or N]");

    //get answer
    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    } 
    else if ( answer == "N")
    {
        return;
    }
    else
    {
        return;
    }
}