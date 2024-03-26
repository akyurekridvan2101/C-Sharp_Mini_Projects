using System;

class PrimeNumbers
{
    static void Main()
    {

        Console.Write("Enter an upper limit: ");
        int upperLimit;

        // Continue the loop until a valid number is entered by the user
        while (true)
        {

            try
            {
                upperLimit = Convert.ToInt32(Console.ReadLine());
                break; // Break out of the loop when a valid number is obtained without errors
            }
            catch (FormatException)
            {
                Console.Write("Error: Please enter only numbers: ");
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Error: An error occurred => " + ex2.Message);
                return; // Terminate the program
            }
        }

        Console.WriteLine($"Prime numbers between 1 and {upperLimit}:");

        // Loop to find prime numbers
        for (int i = 2; i <= upperLimit; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine($"{i} ");
            }
        }

        Console.ReadLine();
    }

    // Function to check whether a given number is prime
    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        int sqrt = (int)Math.Sqrt(number);

        // Loop to check divisors up to the square root
        for (int i = 2; i <= sqrt; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
