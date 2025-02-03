# Hangman Game

A Hangman game built using C# and connected to a database for word selection. This is an interactive console-based experience where players attempt to guess a randomly chosen word, one letter at a time.

## Features

- Database Integration: Fetches a random word from a SQL Server database to ensure variety in gameplay.
- Word Masking: Displays a masked version of the word with underscores representing unguessed letters.
- Guess Feedback: Provides feedback on correct and incorrect guesses.
- Limited Attempts: Players have a maximum of 6 attempts to guess the word.
- Victory and Defeat: Displays appropriate messages when the player either guesses the word correctly or runs out of attempts.

## Challenges

- Retrieving Random Word: Created a database storing words and then using a query  "SELECT TOP 1 Word FROM Words ORDER BY NEWID()" to randomly sort the words and fetch the top result. 
- Case Sensitivity: To ensure user input match the word regardless of upper or lowercase letters, I converted both the word from the database and user's input to lowercase before the comparison.
