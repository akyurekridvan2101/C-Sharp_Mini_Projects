using System;

class Program
{
    static void Main(string[] args)
    {
        // An array containing 100 elements of numbers in ascending order.
        int[] array = {
            1, 10, 11, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70,
            75, 80, 85, 90, 95, 100, 105, 110, 115, 120, 125, 130, 135, 140, 145, 150,
            155, 160, 165, 170, 175, 180, 185, 190, 195, 200, 205, 210, 215, 220, 225,
            230, 235, 240, 245, 250, 255, 260, 265, 270, 275, 280, 285, 290, 295, 300,
            305, 310, 315, 320, 325, 330, 335, 340, 345, 350, 355, 360, 365, 370, 375,
            380, 385, 390, 395, 400, 405, 410, 415, 420, 425, 430, 435, 440, 445, 450,
            455, 460, 465, 470, 475, 480, 485, 490, 495
        };

        int searchNumber;

        while (true)
        {
            try
            {
                // Prompt the user to enter a number.
                Console.Write("Enter a number: ");
                searchNumber = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                // Remind the user to input only integers in case of an error.
                Console.WriteLine("Please enter only integers...");
            }
        }

        // Find the index of the entered number in the array.
        int index = IndexFinder(array, searchNumber);

        // Print the results to the console.
        if (index != -1)
            Console.WriteLine($"Index of {searchNumber} in the array: " + index);
        else
            Console.WriteLine("The searched number is not in the array...");

        // Wait for the user to press a key.
        Console.ReadKey();
    }

    // A function that finds the index of a number in the array using binary search algorithm.
    static int IndexFinder(int[] array, int searchNumber)
    {
        int startIndex = 0, endIndex = array.Length - 1;

        while (startIndex <= endIndex)
        {
            int middleIndex = (startIndex + endIndex) / 2;

            if (searchNumber == array[middleIndex])
                return middleIndex;
            else if (searchNumber < array[middleIndex])
                endIndex = middleIndex - 1;
            else // searchNumber > array[middleIndex]
                startIndex = middleIndex + 1;
        }

        // Return -1 if the searched number is not found.
        return -1;
    }
}
