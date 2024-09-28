using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 110);

        int numberGuess = -1;

        //infintly loops, need to fix that
        while ( numberGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            numberGuess = int.Parse(userGuess);

            if (numberGuess > magicNumber )
            {
                Console.WriteLine("Lower");
            }

            else if ( numberGuess < magicNumber )
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}