using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture();
        scripture.ParseText(scriptureText);
        scripture.DisplayScripture();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string userEnd = Console.ReadLine(); 
        while (userEnd != "quit" && !scripture.IsCompletelyHidden()) 
        {
            Console.Clear();

            scripture.HideThreeWords();
            scripture.DisplayScripture();

            if (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                Console.WriteLine();
                userEnd = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Great Job!");
                Environment.Exit(0); 

            }
        }

    

        
    }
}

//Step one: Hide one word, then try and hide one random word, then try to hide three random words. 

//Test reference to print out classes