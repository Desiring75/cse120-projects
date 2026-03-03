using System;

class Program
{
    static void Main(string[] args)
    {
        //Step 1: Asking user for a magic number
        /*Console.Write("What is the magic number? ");
        string user = Console.ReadLine();
        int userNumber = int.Parse(user);
        int userGuess;
        */

        //Step 3: Creating a random number
        Random randomGenerator = new Random();
        int userNumber = randomGenerator.Next(1,100);
        int userGuess;
        int tries = 0;


        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess == userNumber )
        {
            Console.WriteLine("You guessed it!");
        }

            else if (userGuess < userNumber)
        {
            Console.WriteLine("Higher");
        }

            else
        {
            Console.WriteLine("Lower");
        }

            //Stretch Challenge: Create a tracker to track guesses
            tries += 1;

        } while (userGuess != userNumber);

        Console.WriteLine($"It took you {tries} guesses.");

    }
}