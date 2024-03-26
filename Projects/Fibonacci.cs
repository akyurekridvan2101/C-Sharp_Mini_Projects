using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Variable to hold the user-entered position
            int position = 0;

            while (true)
            {
                try
                {
                    // Get the position from the user
                    Console.Write("Position: ");
                    position = Convert.ToInt32(Console.ReadLine());

                    // Display an error message and ask for input again if the entered position is less than 1
                    if (position < 1)
                        Console.WriteLine("Please enter a number greater than 1.");
                    else
                        break;

                }
                catch (Exception ex)
                {
                    // Clear the console and prompt the user to enter a valid number in case of an error
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number => " + ex.Message);
                }
            }

            // If the entered position is 1 or 2, print 1, otherwise calculate Fibonacci
            if (position == 1 || position == 2)
                Console.WriteLine("1");
            else
            {
                // Clear the console and call the relevant function to calculate Fibonacci
                Console.Clear();
                Console.WriteLine(Fibonacci(position));
            }

            // Wait for a key press before terminating the program
            Console.ReadKey();
        }

        // Calculates the nth Fibonacci number
        static int Fibonacci(int position)
        {
            // Variables to be used for Fibonacci calculation
            int previous = 0, current = 1, next = 0;

            // Calculate the Fibonacci series
            for (int i = 0; i < position - 1; i++)
            {
                next = previous + current;
                previous = current;
                current = next;
            }

            // Return the nth Fibonacci number
            return current;
        }
    }
}
