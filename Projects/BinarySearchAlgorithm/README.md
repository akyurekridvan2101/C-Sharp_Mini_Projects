# Binary Search Example

This project contains a C# program that uses the binary search algorithm to find the index of a number in a sorted array.

## Binary Search: Advantages of the Algorithm

Binary search is an efficient algorithm used to find a specific element in a sorted array. Here are the key advantages of using binary search:

## 1. Fast Performance

Binary search has a logarithmic time complexity (O(log n)) because it halves the search range at each step. This provides fast performance, especially with large datasets.

## 2. Efficient Memory Usage

Binary search continuously halves the search range in a sorted array, requiring minimal memory usage and ensuring memory efficiency.

## 3. Reduced Number of Comparisons

Since binary search halves the search range at each step, it performs fewer comparisons compared to other searching algorithms. This leads to improved efficiency.

Binary search is preferred in situations where a specific element needs to be found quickly in a sorted dataset. Its logarithmic time complexity ensures fast performance even with large datasets, making binary search widely used.

## How It Works?

1. **Array Initialization:** The program contains a sorted array of integers. For example:

    ```csharp
    int[] array = { 1, 10, 11, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, ... };
    ```

2. **User Input:** The user is prompted to enter an integer. Error checking is performed until the user inputs a valid integer.

    ```csharp
    Console.Write("Enter a number: ");
    int searchNumber = Convert.ToInt32(Console.ReadLine());
    ```

3. **Binary Search Operation:** The `IndexFinder` function finds the index of the entered number in the array using the binary search algorithm.

    ```csharp
    int index = IndexFinder(array, searchNumber);
    ```

4. **Result Display:** The obtained index is displayed on the screen if it's not -1. Otherwise, the message "The searched number is not in the array..." is displayed.

    ```csharp
    if (index != -1)
        Console.WriteLine($"Index of {searchNumber} in the array: " + index);
    else
        Console.WriteLine("The searched number is not in the array...");
    ```

5. **Closure:** The program ends when the user presses any key.

    ```csharp
    Console.ReadKey();
    ```
