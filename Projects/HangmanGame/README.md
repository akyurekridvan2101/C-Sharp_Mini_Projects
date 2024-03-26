# **Hangman Game**

This project contains a simple console-based "Hangman" game developed in the C# programming language. The game revolves around guessing the letters of a word chosen by the computer. The player tries to uncover the correct letters with each guess, while incorrect guesses result in the creation of a "hangman" figure. The player wins the game by correctly guessing all the letters before reaching a certain number of mistakes.

## **How the Game Works**

1. **Choosing a Word:** The game initially selects a word randomly from a predefined array of words.
2. **Hiding the Word:** A guessing array is created with underscores (_) equal to the number of letters in the selected word. As each letter is guessed, it is placed in the corresponding positions in this array.
3. **Game Loop:** The game runs within a loop. In each iteration, the player can guess a letter or the entire word.
4. **Guessing a Letter:** The player tries to guess the correct letters by inputting a letter. Guessed correct letters are placed in their corresponding positions in the word.
5. **Error Checking:** For incorrect guesses, the player's mistake count increases, and a "hangman" figure is drawn. The player has a total of 6 chances to make mistakes.
6. **Ending the Game:** The game ends when the player correctly guesses all the letters or reaches a certain number of mistakes.

## **Main Functions and Modules**

- **PrintHangmanRules():** Prints the rules and instructions of the game on the screen at the beginning.
- **DrawHangman():** Draws the "hangman" figure on the screen based on the number of wrong guesses made by the player.
- **UpdateLetters():** Checks the letter entered by the user and updates the correctly guessed letters.
- **Main():** Manages the main loop of the game, including game initiation, word selection, user guesses, and game termination conditions.

## **How to Play**

1. When the game starts, a screen displaying the rules and instructions appears. Press any key to start the game.
2. The player guesses the number of letters in the word and can then input a letter or word guess with each turn.
3. Correct guesses are revealed in their corresponding positions in the word, while incorrect guesses result in the drawing of the "hangman" figure.
4. The game ends when the player correctly guesses all the letters or reaches a certain number of mistakes, and the result is displayed on the screen.

## **How to Run**

1. Compile the project with a C# compiler (Visual Studio, VS Code, etc.).
2. Run the compiled program to start the game.
3. Follow the rules to guess the letters or the word.
4. Observe the result on the screen: Did you win or lose?
