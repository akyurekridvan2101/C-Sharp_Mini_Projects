using System;

public class Program
{
    // Main method, the entry point of the program
    static void Main()
    {
        // Ask the user to enter a word
        Console.Write("Enter a word: ");
        string userWord = Console.ReadLine();

        // Call the IsPalindrome function and print the result
        Console.WriteLine($"Is the entered word a palindrome? {IsPalindrome(userWord)}");
    }

    // Function to check if a word is a palindrome
    static bool IsPalindrome(string word)
    {
        // If the length of the word is 1, it's a palindrome
        if (word.Length == 1)
            return true;

        // Check the first half of the word
        for (int i = 0; i < word.Length / 2; i++)
        {
            // Check if characters are equal in corresponding positions
            if (word[i] != word[word.Length - i - 1])
                return false;
        }

        // If all checks pass, the word is a palindrome
        return true;
    }
}
