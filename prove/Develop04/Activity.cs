public class Activity
{
    //attributes
    private string _name;
    private int _duration;
    private string _description;
    //constructor
    public Activity ()
    {
   
    }
    public Activity (string name, int duration, string description)
    {
        _name = name;
        _duration = duration;
        _description = description;
    }
    //methods
    public int SetDuration()
    {
        //This was grabbed from ChatGPT(work it so it is what I need):
        //could look like this:
        Console.Write("How long would you like the activity to be in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        return duration;
          //LOGIC FOR THE COUNTDOWN TIMER:  
                // {
                // // Start the countdown from 3
                // for (int i = interval; i > 0; i--)
                // {
                //     Console.Write($"\r{i} "); // \r returns the cursor to the start of the line
                //     Thread.Sleep(1000); // Wait for 1 second
                // }
                // // Clear the line after countdown ends
                // Console.Write("\r0 "); // Optionally display 0 at the end
                // Console.WriteLine(); // Move to a new line after countdown
                // }
    }
    public void PlayAnimation()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Console.Write("\b \b"); 

    }
    public void PlayAnimation15()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|");        
        Thread.Sleep(500);
        Console.Write("\b \b");  
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|");        
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|");        
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("|"); 
        Thread.Sleep(500);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(500);
        Console.Write("\b \b");
    }
    public void DisplayTimer()
    {
         DateTime startTime = DateTime.Now;
         DateTime endTime = startTime.AddSeconds(3);
         int secondsRemaining = 3;

         while (secondsRemaining > 0)
         {
            secondsRemaining = (int)(endTime - DateTime.Now).TotalSeconds;

            Console.Write($"\r{secondsRemaining}");

            Thread.Sleep(100);
         }

        Console.Write("\r0 ");
        Console.WriteLine();
        //  Thread.Sleep(3000);

        //  DateTime currentTime = DateTime.Now;
        
    }
    public void EndMessage(int duration, string activity)
    {
        Console.WriteLine("Well Done!");
        Thread.Sleep(100);
        PlayAnimation();
        Thread.Sleep(100);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {duration} seconds of the {activity} activity");
        Thread.Sleep(100);
        PlayAnimation();
        Console.Clear();
    }
}