using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("14 Dec 2024", 30, 4);
        activities.Add(running1);

        Cycling cycling1 = new Cycling("14 Dec 2024",40,15);
        activities.Add(cycling1);

        Swimming swimming1 = new Swimming("14 Dec 2024", 30, 32);
        activities.Add(swimming1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.DisplaySummary());
        }    
    }
}