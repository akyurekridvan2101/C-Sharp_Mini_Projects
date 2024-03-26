using System;
using System.Threading;

namespace DiceGame
{
    // The Dice class represents the dice object used in the dice game.
    class Dice
    {
        int[] diceFaces; // Array to hold the numbers written on the faces of the dice.
        Random random; // Random object to generate random numbers. It's defined as a class member to avoid creating a new instance every time.

        // Constructor for the Dice class initializes the dice faces.
        public Dice()
        {
            random = new Random();
            diceFaces = new int[6];
            AssignNumbersToDiceFaces();
        }

        // Method to assign different numbers to the faces of the dice.
        public void AssignNumbersToDiceFaces()
        {
            for (int i = 0; i < 6; i++)
            {
                int randomNumber;
                while (true)
                {
                    randomNumber = this.random.Next(1, 26); // Generates a random number between 1 and 25.

                    bool numberExists = NumberExistsInDice(randomNumber, i);

                    if (!numberExists)
                    {
                        this.diceFaces[i] = randomNumber;
                        break;
                    }
                }
            }
        }

        // Method to check if the given number already exists in the dice faces.
        private bool NumberExistsInDice(int randomNumber, int currentIndex)
        {
            for (int j = 0; j < currentIndex; j++)
            {
                if (this.diceFaces[j] == randomNumber)
                    return true;
            }
            return false;
        }

        // Method to roll the dice.
        public int RollDice()
        {
            return diceFaces[random.Next(6)];
        }
    }

    // The Player class represents a player in the dice game.
    class Player
    {
        public readonly string Name; // Player's name, marked as readonly to make it unchangeable after initialization.
        public int Score { get; set; } = 0; // Property to hold the player's total score.

        // Constructor for the Player class initializes the player's name.
        public Player(string playerName)
        {
            this.Name = playerName;
        }

        // Method to increase the player's score by rolling the dice.
        public void AddScore(Dice diceObject)
        {
            int rolledNumber = diceObject.RollDice();
            Score += rolledNumber;
            Console.WriteLine($"{Name} rolled {rolledNumber}. Total Score: {Score}");
            Thread.Sleep(1000); // Adding a delay to make it more readable.
        }
    }

    class Program
    {
        // Main method to start and display the results of the dice game.
        static void Main(string[] args)
        {
            Dice dice = new Dice(); // There should be only one dice object for both players to ensure fairness.

            Console.Write("Player 1 Name: ");
            string player1Name = Console.ReadLine();

            Console.Write("Player 2 Name: ");
            string player2Name = Console.ReadLine();

            Player player1 = new Player(player1Name) { Score = 0 };
            Player player2 = new Player(player2Name) { Score = 0 };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("********* CURRENT SCORES *********");
                Console.WriteLine($"{player1.Name}: {player1.Score}");
                Console.WriteLine($"{player2.Name}: {player2.Score}\n");

                Console.WriteLine($"Press any key for {player1Name} to roll the dice...");
                Console.Read();
                player1.AddScore(dice);

                Console.WriteLine($"\nPress any key for {player2Name} to roll the dice...\n");
                Console.ReadKey();
                player2.AddScore(dice);

                if (player1.Score >= 50 || player2.Score >= 50)
                    break;
            }

            DisplayResults(player1, player2);
            Console.ReadKey();
        }

        // Method to display the results of the players.
        public static void DisplayResults(Player player1, Player player2)
        {
            Console.Clear();

            Console.WriteLine($@"{player1.Name}'s Score = {player1.Score}
    {player2.Name}'s Score = {player2.Score}");

            Console.ForegroundColor = ConsoleColor.Green;
            if (player1.Score > player2.Score)
                Console.WriteLine($"{player1.Name} wins!");
            else if (player1.Score == player2.Score)
                Console.WriteLine("It's a tie...");
            else
                Console.WriteLine($"{player2.Name} wins!");

            Console.ResetColor();
        }
    }
}
