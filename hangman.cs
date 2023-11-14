using System;

class Program
{
    static void Main()
    {
        HangmanGame hangmanGame = new HangmanGame();
        hangmanGame.StartGame();
    }
}

class HangmanGame
{
    private string[] words = { "programming", "hangman", "computer", "developer", "code" };
    private string selectedWord;
    private char[] guessedWord;
    private int attemptsLeft;
    private string incorrectLetters;

    public void StartGame()
    {
        Random random = new Random();
        selectedWord = words[random.Next(words.Length)];
        guessedWord = new char[selectedWord.Length];
        attemptsLeft = 6; // * 
        incorrectLetters = "";

        for (int i = 0; i < selectedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }

        while (attemptsLeft > 0)
        {
            DisplayGameStatus();
            Console.Write("Enter a letter: ");
            char guessedLetter = Console.ReadKey().KeyChar;

            // * 
            if (selectedWord.Contains(char.ToLower(guessedLetter)))
            {
                UpdateGuessedWord(guessedLetter);
            }
            else
            {
                attemptsLeft--;
                incorrectLetters += guessedLetter + " "; // * 
            }

            if (Array.IndexOf(guessedWord, '_') == -1)
            {
                Console.WriteLine("\nCongratulations! You guessed the word: " + selectedWord);
                return;
            }
        }

        Console.WriteLine("\nSorry! You ran out of attempts. The word was: " + selectedWord);
    }

    private void DisplayGameStatus()
    {
        Console.Clear();
        Console.WriteLine("Hangman Game");
        Console.WriteLine("Word: " + new string(guessedWord)); // * 
        Console.WriteLine("Attempts Left: " + attemptsLeft);
        Console.WriteLine("Incorrect Letters: " + incorrectLetters);
    }

    private void UpdateGuessedWord(char letter)
    {
        for (int i = 0; i < selectedWord.Length; i++)
        {
            if (char.ToLower(selectedWord[i]) == char.ToLower(letter))
            {
                guessedWord[i] = selectedWord[i];
            }
        }
    }
}
