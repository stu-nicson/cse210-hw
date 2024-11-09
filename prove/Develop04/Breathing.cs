public class Breathing : Activity
{
    //attributes
    private int _breatheIn;
    private int _breatheOut;
    //constructor
    public Breathing ()
    {
    
    }
    public Breathing (int breatheIn, int breatheOut)
    {
        _breatheIn = breatheIn;
        _breatheOut = breatheOut;
    }
    //methods
    //NOTE:
    //I believe this will look like a while loop saying "while duration != 0 run, breathe in, breathe out, with the countdown"
    public void StartBreathing()
    {
        _breatheIn = 5;
            // Start the countdown from 3
            for (int i = _breatheIn; i > -1; i--)
            {
                Console.Write($"\rBreathe in...{i} "); // \r returns the cursor to the start of the line
                Thread.Sleep(1000); // Wait for 1 second
            }
    }
    public void StopBreathing()
    {
         _breatheOut = 5;
            // Start the countdown from 3
            for (int i = _breatheOut; i > -1; i--)
            {
                Console.Write($"\rNow breathe out...{i} "); // \r returns the cursor to the start of the line
                Thread.Sleep(1000); // Wait for 1 second
            }
            
    }
    public void RunBreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and \nout slowly. Clear your mind and focus on your breathing.\n");

        // SetDuration();
        int duration = SetDuration();
        Console.Write("When you are ready to begin, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Begin...");
        Thread.Sleep(1000);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                StartBreathing();
                Thread.Sleep(1000);
                Console.WriteLine("\n");
                StopBreathing();
                Console.WriteLine("\n");
            }
            // Console.Write($"\r{i} "); // \r returns the cursor to the start of the line
            // Thread.Sleep(1000); // Wait for 1 second
            
        EndMessage(duration, "Breathing");
    }
    
}