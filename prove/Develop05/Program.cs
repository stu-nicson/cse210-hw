using System;

class Program
{

    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        

        int userChoice;
        do
        {
            string fileName;
            int points = 0;
            foreach (Goal goals in goalList)
            {
                points += goals.GetCurrentPoints();
            }
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int count = 1;
        

        if (int.TryParse(input, out userChoice) && userChoice >= 1 && userChoice <= 6)
        {
            switch (userChoice)
            {
                case 1:
                    //Display Goal Menu

                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int goalChoice = int.Parse(Console.ReadLine());

                    switch (goalChoice)
                    {
                        case 1: 
                        SimpleGoal simpleGoal1 = new SimpleGoal();
                        simpleGoal1.ConstructGoal();
                        // simpleGoal1.DisplayGoal();
                        goalList.Add(simpleGoal1);
                        break;

                        case 2:
                        Eternal eternal1 = new Eternal();
                        eternal1.ConstructGoal();
                        goalList.Add(eternal1);
                        break;

                        case 3:
                        Checklist checklist1 = new Checklist();

                        checklist1.ConstructGoal(0);
                        goalList.Add(checklist1);
                        break;
                        
                        default:
                        Console.WriteLine("Invalid Selection");
                        break;
                    }

                    break;
                case 2:
                    Console.WriteLine("The goals are: "); 
                    foreach (Goal goals in goalList)
                    {
                        count = goals.DisplayGoal(count);
                    }
                    //display goals
                    break;
                case 3:
                    Console.WriteLine("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal goals in goalList)
                        {
                            goals.WriteGoal(fileName, outputFile);                        
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    string[] lines= System.IO.File.ReadAllLines(fileName);
                    goalList = new();
                    for (int i = 0; i < lines.Length;)
                    {
                        string switch_on = lines[i];
                        switch (switch_on)
                        {
                            case "SimpleGoal":
                            bool simpleDone = Convert.ToBoolean(lines[i+1]);
                            string simpleName = lines[i+2];
                            string simpleDescription = lines[i+3];
                            int simplePointValue = int.Parse(lines[i+4]);
                            int simpleCompletePoints = int.Parse(lines[i+5]);
                            SimpleGoal simpleGoal1 = new ();
                            simpleGoal1.ConstructGoal(simpleDone, simpleName, simpleDescription, simplePointValue, simpleCompletePoints);
                            i+=6;
                            goalList.Add(simpleGoal1);
                            break;

                            case "Eternal":
                            bool eternalDone = Convert.ToBoolean(lines[i+1]);
                            string eternalName = lines[i+2];
                            string eternalDescription = lines[i+3];
                            int eternalPointValue = int.Parse(lines[i+4]);
                            Eternal eternal1 = new();
                            eternal1.ConstructGoal(eternalDone, eternalName, eternalDescription, eternalPointValue);
                            i+=5;
                            goalList.Add(eternal1);
                            break;

                            case "Checklist":
                            bool checklistDone = Convert.ToBoolean(lines[i+1]);
                            string checklistName = lines[i+2];
                            string checklistDescription = lines[i+3];
                            int checklistPointValue = int.Parse(lines[i+4]);
                            int checklistTimesCompleted = int.Parse(lines[i+5]);
                            int checklistTimesToComplete = int.Parse(lines[i+6]);
                            int checklistBonusPoints = int.Parse(lines[i+7]);
                            int checklistCompletePoints = int.Parse(lines[i+8]);
                            Checklist checklist1 = new();
                            checklist1.ConstructGoal(checklistDone, checklistName, checklistDescription, checklistPointValue, checklistTimesCompleted, checklistTimesToComplete, checklistBonusPoints, checklistCompletePoints, 0);
                            i+=9;
                            goalList.Add(checklist1);
                            break;
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("The goals are: "); 
                    foreach (Goal goals in goalList)
                    {
                        count = goals.GetName(count);
                    }
                    Console.Write("Which goal did you accomplish: ");
                    goalList[Convert.ToInt16(Console.ReadLine())-1].RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Unsaved Goals may be lost!!");
                    Console.Write("Would you like to save your work? (y/n)");
                    string save = Console.ReadLine();

                    if (save == "y")
                    {
                        Console.WriteLine("What is the filename for the goal file? ");
                        fileName = Console.ReadLine();
                        using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            foreach (Goal goals in goalList)
                            {
                                goals.WriteGoal(fileName, outputFile);                        
                            }
                    }
                    }
                    break;
                
                default:
                        Console.WriteLine("Invalid Selection");
                        break;
            }
        }
        else 
        {
            Console.WriteLine("Invalid selection please try again.");
        }
        } while (userChoice != 6);


    }
    public void HandleMenu()
    {

    }

}