using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter text
        Console.Write("Enter text: ");
        string text = Console.ReadLine() ?? "null value";

        // Send the text to the PrintBytes method
        PrintBytes(text);
    }

    // Method to print the text in binary format
    static void PrintBytes(string text)
    {
        if (String.IsNullOrEmpty(text))
        {
            // Display an error message if the text is empty or null
            Console.WriteLine("Text was not entered, so it couldn't be converted...");
        }
        else
        {
            foreach (char character in text.ToCharArray())
            {
                // Call the method to convert the character to binary format and print it to the console
                char[] bits = CharToBits(character).ToCharArray();
                Array.Reverse(bits);
                Console.WriteLine(bits);
            }
            Console.WriteLine(); // Add a line break
        }
    }

    // Method to convert the character to binary format
    static string CharToBits(char nextCharacter)
    {
        int asciiValue = nextCharacter;

        // Create a 16-bit array to represent the binary of the character
        char[] bits = "0000000000000000".ToCharArray();

        if (asciiValue == 0)
            return "0000000000000000";

        int max = 0, numberCheck = 0;

        // Loop to construct the binary representation of the character
        for (int i = 0; i <= 15; i++)
        {
            if (Math.Pow(2, i) > asciiValue)
            {
                max = i - 1;
                bits[max] = '1';
                break;
            }
        }

        numberCheck += (int)Math.Pow(2, max);

        // Loop to continue constructing the binary representation of the character
        for (int i = max - 1; i >= 0; i--)
        {
            if (numberCheck + (int)Math.Pow(2, i) <= asciiValue)
            {
                bits[i] = '1';
                numberCheck += (int)Math.Pow(2, i);
            }
        }

        return new string(bits);
    }
}
