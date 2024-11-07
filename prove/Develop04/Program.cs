using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Activity activityA = new Activity();
        activityA.PlayAnimation();

    }
    public void HandleMenu()
    {
            List<string> menu = new();
            Console.Write("Which activy would you like to do? ");
            string userInput = Console.ReadLine();
    }
}
