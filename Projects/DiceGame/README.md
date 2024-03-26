# Dice Game

## Description
This C# program simulates a dice game where two players roll dice and earn points. Players take turns rolling the dice, and the numbers they roll are added to their total scores. The game ends when one player reaches 50 points, and the winner is determined.

## Game Rules
- A common dice is used for both players, ensuring that the faces of the dice are the same.
- Players take turns rolling the dice and adding the rolled numbers to their total scores.
- The game ends when one player reaches 50 points.
- The winner is determined at the end of the game, and the results are displayed on the screen.

## Dice Class
1. The Dice class represents the dice object used in the dice game.
2. Different numbers are assigned to the faces of the dice, and random number generation is performed.
3. The same dice object is used for each player to ensure fair gameplay.

## Player Class
1. The Player class represents a player in the dice game.
2. It contains properties for the player's name and total score.
3. It includes a method to increase the player's score by rolling the dice.

## Program Flow
1. A dice object is created, and player names are obtained from the user.
2. The game starts, with both players taking turns rolling the dice and adding to their scores.
3. Current scores are displayed on the screen.
4. The game continues until one player reaches 50 points.
5. The results are displayed on the screen, and the winner is determined.

## Example Usage
1. Player 1 Name: [Enter player name]
2. Player 2 Name: [Enter another player name]
3. Press any key to start the game.
4. Players take turns rolling the dice, and their scores are displayed.
5. The game continues until one player reaches 50 points.
6. The results are displayed on the screen.

## Notes
- An infinite loop is used to keep the game running continuously.
- A short delay is added during dice rolling to improve readability.
- The game results are displayed in color for better visualization.
