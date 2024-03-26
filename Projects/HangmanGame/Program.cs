using System;

class Program
{
    // Array containing words
    static readonly string[] words = {
        "computer",
        "engineering",
        "software",
        "hardware",
        "algorithm",
        "database",
        "electronics",
        "programming",
        "android",
        "robotics"
    };

    // Variable to store the number of mistakes
    static int mistakeCount = 0;

    static void Main()
    {
        // Function to print the rules of the game
        PrintHangmanRules();

        // Select a random word
        string word = words[new Random().Next(0, words.Length)];
        string[] wordGuess = new string[word.Length];

        // Initialize the word guess array with '_'
        for (int i = 0; i < word.Length; i++)
        {
            wordGuess[i] = "_";
        }

        // Loop for the game to continue
        while (mistakeCount != 6)
        {
            Console.Clear();
            // Draw the hangman figure
            DrawHangman();
            Console.WriteLine();

            // Print the word guess status
            for (int i = 0; i < wordGuess.Length; i++)
            {
                Console.Write($" {wordGuess[i]} ");
            }

            int choice;

            // Loop until a valid choice is entered by the user
            while (true)
            {
                try
                {
                    Console.Write("To guess a letter => Press 1\n" +
                        "To guess the answer => Press 2 (You will lose if you answer incorrectly)\n\n" +
                        "Press Enter after making your choice: ");

                    // Get the user's choice
                    choice = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease enter only 1 or 2\n");
                    Console.ResetColor();
                }
            }

            // Perform actions based on the user's choice
            if (choice == 1)
            {
                char letter;

                // Loop until a valid letter is entered by the user
                while (true)
                {
                    try
                    {
                        Console.Write("Enter a letter: ");
                        letter = Convert.ToChar(Console.ReadLine().ToLower());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter only one letter");
                        continue;
                    }

                    break;
                }

                // Check the letter guess and increase the mistake count if necessary
                if (!UpdateLetters(word, ref wordGuess, letter))
                    mistakeCount++;
            }

            else if (choice == 2)
            {
                // Get the user's word guess
                Console.Write("Guess the word: ");
                string answer = Console.ReadLine().ToLower();

                // Check the user's word guess
                if (answer == word)
                {
                    Console.Clear();
                    DrawHangman();
                    Console.WriteLine("Congratulations, you won the game");
                    break;
                }
                else
                {
                    Console.Clear();
                    mistakeCount = 6;
                    DrawHangman();
                    Console.WriteLine("You lost the game");
                    break;
                }
            }

            // Perform actions based on the game state
            if (mistakeCount == 6)
            {
                Console.Clear();
                DrawHangman();
                Console.WriteLine("You lost the game");
                break;
            }
            else if (string.Join("", wordGuess) == word)
            {
                Console.Clear();
                DrawHangman();
                Console.WriteLine("Congratulations, you won the game");
                break;
            }
        }
    }

    // Function to print the rules of the game
    static void PrintHangmanRules()
    {
        Console.WriteLine(
        @"
=======================================
      HANGMAN GAME RULES   
=======================================
1. The computer selects a word.
2. The player guesses the number of letters in the selected word.
3. The player guesses one letter at a time.
4. Correctly guessed letters are placed in their respective positions in the word.
5. A mistake count is incremented for each incorrectly guessed letter.
6. If the player reaches a certain mistake count, the game is lost.
7. The player wins the game if all the letters are guessed correctly.

=======================================
  PRESS ANY KEY TO START THE GAME   
======================================="
        );

        Console.ReadKey();
    }

    // Function to draw the hangman figure
    static void DrawHangman()
    {
        string[] pics = {
            @"
           +---+
           |   |
               |
               |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
               |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
           |   |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|   |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
               |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
          /    |
               |
        =========",
            @"
           +---+
           |   |
           O   |
          /|\  |
          / \  |
               |
        ========="
        };

        Console.WriteLine(pics[mistakeCount]);
    }

    // Function to update the letter
    static bool UpdateLetters(string answer, ref string[] wordGuess, char letter)
    {
        bool isLetterCorrect = false;
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == letter)
            {
                isLetterCorrect = true;
                wordGuess[i] = $"{letter}";
            }
        }

        return isLetterCorrect;
    }
}
