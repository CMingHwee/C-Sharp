using System;
using Microsoft.Data.SqlClient;

class HangmanGame
{
    static void Main()
    {
        string connectionString = "data source=DESKTOP-NSNRK1I;initial catalog=HangmanDB;TrustServerCertificate=True;trusted_connection=true"; //connect to database
        string wordToGuess = GetRandomWordFromDatabase(connectionString); //get a random word from the database
        string maskedWord = new string('_', wordToGuess.Length); //string of underscores equal to length of wordToGuess
        int attemptsLeft = 6; 
        bool isWordGuessed = false;
        char[] guessedLetters = new char[wordToGuess.Length]; //track guessed letters
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Try to guess the word, one letter at a time.");
        Console.WriteLine($"The word has {wordToGuess.Length} letters.");

        while (attemptsLeft > 0 && !isWordGuessed)
        {
            Console.WriteLine($"\nWord: {maskedWord}");
            Console.WriteLine($"Attempts left: {attemptsLeft}");
            Console.Write("Enter a letter: ");
            char guess = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();//read key press and assign it to guess and then output a blank line for readibility 

            if (wordToGuess.Contains(guess))
            {
                Console.WriteLine("Correct!");
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                        guessedLetters[i] = guess;
                } //reveal letter when guessed correctly
            }
            else
            {
                Console.WriteLine("Wrong guess.");
                attemptsLeft--;
            } //minus one attempt if guessed wrongly

            maskedWord = UpdateMaskedWord(wordToGuess, guessedLetters);
            isWordGuessed = !maskedWord.Contains('_');
        }

        if (isWordGuessed)
        {
            Console.WriteLine($"\nCongratulations! You guessed the word: {wordToGuess}");
        }
        else
        {
            Console.WriteLine($"\nGame Over! The word was: {wordToGuess}");
        }
    }

    static string GetRandomWordFromDatabase(string connectionString)
    {
        string randomWord = string.Empty;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT TOP 1 Word FROM Words ORDER BY NEWID()"; //sort words by random order and then selecting the top result

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    randomWord = reader["Word"].ToString(); //retrieve Word and assign to randomWord
                }
            }
        }

        return randomWord.ToLower(); //ensure the word is lowercase for comparison
    }

    static string UpdateMaskedWord(string word, char[] guessedLetters)
    {
        char[] updatedMaskedWord = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            updatedMaskedWord[i] = guessedLetters[i] == '\0' ? '_' : guessedLetters[i]; //turn unguessed  letters into underscores
        }

        return new string(updatedMaskedWord);
    }
}
