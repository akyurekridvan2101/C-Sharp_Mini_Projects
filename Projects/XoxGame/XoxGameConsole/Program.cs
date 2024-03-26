using System;

class Program
{
    // Array representing the game board
    static string[] ticTacToeBoard = { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   " };
    static int winningPlayer = 0; // 0: No winner, 1: Player 1, 2: Player 2

    static void Main()
    {
        string player_1, player_2;

        Console.Write("Enter Player 1's name: ");
        player_1 = Console.ReadLine() ?? "Player 1";
        Console.Write("Enter Player 2's name: ");
        player_2 = Console.ReadLine() ?? "Player 2";

        Console.Clear();

        Console.WriteLine("Game Board");
        ShowBoard();

        for (int i = 1; i <= 9; i++)
        {
            // Update the board with X or O based on player turn
            UpdateBoard((i % 2 == 0) ? 2 : 1, 0, 0);
            ShowBoard();

            // Check for a winner
            if (CheckWinner())
            {
                string winnerMessage = (i % 2 != 0) ? $"{player_1} WINS..." : $"{player_2} WINS...";

                Console.WriteLine($"\n{winnerMessage}");
                break;
            }
        }

        if (winningPlayer == 0)
            Console.WriteLine("\nDRAW...");
    }

    // Method to display the game board
    static void ShowBoard()
    {
        Console.ForegroundColor = ConsoleColor.Black;

        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0)
            {
                Console.ResetColor();
                Console.WriteLine();
            }

            // Alternate colored backgrounds
            Console.BackgroundColor = (i % 2 == 0) ? ConsoleColor.Red : ConsoleColor.Blue;
            Console.Write($"{ticTacToeBoard[i]}");
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    // Method to update the game board based on player's move
    static void UpdateBoard(int playerCharacter, int row, int column)
    {
        while (true)
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter the row(Should be between 1 and 3): ");
                    row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter the column(Should be between 1 and 3): ");
                    column = Convert.ToInt32(Console.ReadLine());

                    // Valid move check
                    if (row < 1 || row > 3 || column < 1 || column > 3)
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("Please enter a value between 1 and 3...");
                        continue;
                    }
                    else if (ticTacToeBoard[(row - 1) * 3 + (column - 1)] != "   ")
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("This position is already occupied...");
                        continue;
                    }
                    else
                        break;
                }

                break;
            }
            catch (Exception)
            {
                Console.Clear();
                ShowBoard();
                Console.WriteLine("Please enter a valid value...");
            }
        }

        // Update the board with X or O based on player's character
        ticTacToeBoard[(row - 1) * 3 + (column - 1)] = playerCharacter == 1 ? " X " : " O ";
    }

    // Method to check for a winner
    static bool CheckWinner()
    {
        // Row, column, and diagonal checks
        if (ticTacToeBoard[0] != "   " && ticTacToeBoard[0] == ticTacToeBoard[1] && ticTacToeBoard[1] == ticTacToeBoard[2])
            return true;
        else if (ticTacToeBoard[3] != "   " && ticTacToeBoard[3] == ticTacToeBoard[4] && ticTacToeBoard[4] == ticTacToeBoard[5])
            return true;
        else if (ticTacToeBoard[6]
