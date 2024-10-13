using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Menu();
    }
    public void Menu()
    {
        Journal journal = new Journal();

        
        int menuInput = 0;
        while (menuInput != 5)
        {
        Console.Write("Please select one of the Following choices \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \nWhat would you like to do: ");

        string input = Console.ReadLine();
            if(int.TryParse(input, out menuInput))
        {
            if (menuInput == 1)
            {
                journal.inputEntry();
            }

            else if (menuInput == 2)
            {
                journal.displayJournal();
            }

            else if (menuInput == 3)
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine();
                journal.readEntries(fileName);
            }
        
            else if (menuInput == 4)
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine();
                journal.writeEntries(fileName);
            }
            
        }
        }
        {
            Console.WriteLine("Unsaved Entries may be lost!!");
            Console.Write("Would you like to save your work? (y/n)");
            string save = Console.ReadLine();

            if (save == "y")
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine();
                journal.writeEntries(fileName);
            }
            else
            {
                Console.WriteLine("Bye");

            }
        }
        
    }
}