using System;

class Program
{
    static void Main(string[] args)
    {    
        DisplayWelcome();
        string personName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);

        DisplayResult(personName, squared);
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        string userName = Console.ReadLine(); 
        return userName;
    }
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int square)
    {
        int squareNumber = square * square;
        return squareNumber;

    }
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
    }


}