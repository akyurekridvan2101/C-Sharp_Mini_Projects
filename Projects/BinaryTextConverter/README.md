**Binary Converter Application**

This C# program is a simple application that converts the text input provided by the user into binary format and prints it to the console.

**Why Powers of 2 are Used**

Powers of 2 are a commonly used concept in mathematics and computer science. This concept essentially refers to numbers expressed as powers of 2. Powers of 2 represent how many times a number is multiplied by itself. Generally, 2 raised to the power of n (2^n) means 2 multiplied by itself n times.

For example:

2 raised to the power of 0 (2^0) = 1
2 raised to the power of 1 (2^1) = 2
2 raised to the power of 2 (2^2) = 2 * 2 = 4
2 raised to the power of 3 (2^3) = 2 * 2 * 2 = 8
and so on.
This concept is frequently used in computer science, especially in the binary system, because computers typically use the binary number system. Each bit can be thought of as a power of 2. For instance, an 8-bit binary number can be constructed using 8 different powers of 2 ranging from 2^7 to 2^0.

In the function, powers of 2 are utilized with the expression Math.Pow(2, i), which calculates 2 raised to the power of i. Using these powers, the function converts the ASCII value of a character into binary format.

**How to Use**

1. Launch the program.
2. You will be prompted to enter text input. Enter some text and press Enter.
3. The program will convert each character's ASCII value into binary format and print it to the console.

**Note:** It should be noted that C# allocates 2 bytes (16 bits) for each character, unlike many other languages, which allocate 1 byte. I have coded the program considering this fact.

**Example**

```bash
Enter text: Hello

0000000001001000
0000000001100101
0000000001101100
0000000001101100
0000000001101111

```

In the example above, when the text "Hello" is entered, each character's ASCII value is converted into binary format.

**Notes**

- If an empty text is entered, you will receive an error message saying "Text was not entered, so it couldn't be converted...".
- The logic for creating the binary representation of each character based on its ASCII value is explained in detail within the program.
- The program prints the binary representation of each character in reverse order.