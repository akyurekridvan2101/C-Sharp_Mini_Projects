using System;

class Program
{
    static void Main()
    {
        uint number;

        // Continue the loop until a valid positive integer input is entered by the user.
        while (true)
        {
            Console.Write("Enter a number (Should be a positive integer.): ");

            // Check the user's input, and exit the loop if it's a valid positive integer.
            if (uint.TryParse(Console.ReadLine(), out number) && number != 0)
            {
                break;
            }
            else
            {
                // Show a warning message to the user in case of invalid input.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a positive integer.");
                Console.ResetColor();
            }
        }

        // Check if the number is a perfect number and print the result.
        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }

    // Function to check if a number is a perfect number.
    static bool IsPerfectNumber(uint number)
    {
        int sum = 0;

        // Check the divisors up to half of the number.
        // Exit the loop if the sum exceeds the number.
        for (int i = 1; i <= number / 2 && sum <= number; i++)
        {
            // If i is a divisor of the number, add it to the sum.
            if (number % i == 0)
            {
                sum += i;
            }
        }

        // If the sum is equal to the number, it's a perfect number.
        return sum == number;
    }
}
