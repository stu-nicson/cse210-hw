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
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void PlayAnimation()
    {
        Console.Write("|");
        Thread.Sleep(750);
        Console.Write("\b \b"); 
        Console.Write("\\"); 
        Thread.Sleep(5750);
        Console.Write("\b \b"); 
        Console.Write("-"); 
        Thread.Sleep(750);
        Console.Write("\b \b"); 
        Console.Write("/");
        Thread.Sleep(750);
        Console.Write("\b \b"); 
        Console.Write("|"); 
    }
    public void DisplayTimer()
    {
         DateTime startTime = DateTime.Now;
         DateTime futureTime = startTime.AddSeconds(5);

         Thread.Sleep(3000);

         DateTime currentTime = DateTime.Now;
        
    }
    public void EndMessage()
    {
        
    }
}