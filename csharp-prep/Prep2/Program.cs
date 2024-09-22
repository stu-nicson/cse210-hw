using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have a {letter}");
        
        if (number >= 70)
        {
            Console.WriteLine("Congrats on the passing grade! Keep it up.");
        }
        else 
        {
            Console.WriteLine("Not quite a passing grade! You got it next time!");
        }

    }
}