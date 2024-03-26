using System;

class FactorialCalculator
{
    static void Main()
    {
        // Ask the user to enter the number for which factorial will be calculated
        Console.Write("Enter the number to calculate factorial for: ");
        int number;

        // Continue the loop until a valid number is entered by the user
        while (true)
        {
            try
            {
                // Convert the user input to an integer
                number = Convert.ToInt32(Console.ReadLine());

                // Break out of the loop when a valid number is obtained without errors
                break;
            }
            catch (FormatException)
            {
                // Display an error message if the user enters non-numeric input and prompt for another number
                Console.Write("Error: Please enter only numbers: ");
            }
            catch (Exception ex)
            {
                // Display a general error message for other possible errors and terminate the program
                Console.WriteLine("Error: An error occurred => " + ex.Message);
                return;
            }
        }

        // Check if the entered number is negative
        if (number < 0)
            Console.WriteLine("Factorial is not defined for negative numbers.");
        else if (number == 0)
            Console.WriteLine("0! = 1");
        else
            // Call the FactorialCalculate function to calculate factorial and print the result
            Console.WriteLine($"{number}! = {FactorialCalculate(number)}");
    }

    // A recursive function to calculate factorial
    static int FactorialCalculate(int number)
    {
        // Base case: factorial of 0 is 1
        if (number == 0)
            return 1;
        else
            // Recursive case: number * (number-1)!
            return number * FactorialCalculate(number - 1);
    }
}
