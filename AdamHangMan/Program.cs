using System;
using System.Text;
namespace AdamHangMan
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Welcome to Adam's Hangman Game!");
            string[] wordList = new string[10];
            wordList[0] = "dinosaur";
            wordList[1] = "volcano";
            wordList[2] = "energy";
            wordList[3] = "wilderness";
            wordList[4] = "snowflake";
            wordList[5] = "development";
            wordList[6] = "placebo";
            wordList[7] = "toothpaste";
            wordList[8] = "waffle";
            wordList[9] = "distribution";
            Random rand = new Random();
            var randomword = rand.Next(0, 9);
            string mysteryword = wordList[randomword];
            char[] guess = new char[mysteryword.Length];
            Console.WriteLine("Please enter your guess: ");

            for (int i = 0; i < mysteryword.Length; i++)
                guess[i] =  '*';

            while(true)
            {
                try
                {
                    char playerguess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < mysteryword.Length; j++)
                    {
                        if (playerguess == mysteryword[j])
                            guess[j] = playerguess;
                    }
                    Console.WriteLine(guess);
                }
                catch
                {
                    Console.WriteLine("Please only guess one character at a time");
                }
                StringBuilder guesses = new StringBuilder();
                foreach (char letter in guess)
                {
                    guesses.Append(letter);
                    string abc = guesses.ToString();
                    if (abc == mysteryword)
                    {
                        Console.WriteLine("Well Done! You have guessed the word correctly!");
                        
                        
                    }
                }
               
                
            }
        }
    }
}
