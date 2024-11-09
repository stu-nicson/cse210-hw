using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        HandleMenu();
        // Console.WriteLine("Hello Develop04 World!");
        // Activity activityA = new Activity();
        // activityA.PlayAnimation();
        // activityA.DisplayTimer();

        // activityA.SetDuration();
        // activityA.EndMessage();


        // Breathing breatheTest = new Breathing();
        // breatheTest.RunBreathingActivity();

        // Reflection reflectionTest = new Reflection();
        // reflectionTest.RunReflection();

        // Listing listingTest = new Listing();
        // listingTest.RunListing();
    }

    public static void HandleMenu()
    {
        int number = 0;
            while (number != 4)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start Breathing Activity");
                Console.WriteLine("  2. Start Reflecting Activity");
                Console.WriteLine("  3. Start Listing Activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");
                string userInput = Console.ReadLine();
                bool success = int.TryParse(userInput,out number);
                if (!success)
                {
                    Console.WriteLine("Failed");
                }
                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Breathing breatheTest = new Breathing();
                        breatheTest.RunBreathingActivity();
                        break;
                    
                    case 2:
                        Console.Clear();
                        Reflection reflectionTest = new Reflection();
                        reflectionTest.RunReflection();
                        break;
                    
                    case 3:
                        Console.Clear();
                        Listing listingTest = new Listing();
                        listingTest.RunListing();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                
               
            }
    }
}
