using System;

class Program
{
    // The Random object should be created only once and should not start with the same seed each time.
    static Random random = new Random(Guid.NewGuid().GetHashCode());

    // Variable to track the number of guesses made by the user.
    static int guessCount = 0;

    // Main method where the game starts.
    static void Main()
    {
        // Generate a random number between 1 and 100
        int generatedNumber = random.Next(1, 100);

        // Loop where the user tries to guess the number
        while (!GuessNumber(generatedNumber)) ;
    }

    // Method where the user guesses the number.
    static bool GuessNumber(int generatedNumber)
    {
        // Increment the number of guesses made by the user.
        guessCount++;

        // User's guess
        int userGuess;

        // Loop until the user enters a valid integer
        while (true)
        {
            try
            {
                Console.Write("Your guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                // Inform the user in case of a format error
                Console.Write("\nPlease enter only integers...\n");
            }
            catch (Exception ex)
            {
                // Inform the user about unexpected errors other than format errors
                Console.Write("\nAn error occurred: " + ex.Message + "\n");
            }
        }

        // Provide feedback based on the user's guess
        if (userGuess < generatedNumber)
        {
            Console.WriteLine("Increase the number...");
            return false;
        }
        else if (userGuess > generatedNumber)
        {
            Console.WriteLine("Decrease the number...");
            return false;
        }
        else
        {
            // User has guessed the number correctly
            Console.WriteLine($"Congratulations! You found the number in {guessCount} guesses...");
            return true;
        }
    }
}
