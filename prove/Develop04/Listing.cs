public class Listing : Activity
{
    //attributes
    private List<string> _listOfPrompts = new List<string>
    {"--- Who are people that you appreciate? ---",
    "--- What are personal strengths of yours? ---",
    "--- Who are people that you have helped this week? ---",
    "--- When have you felt the Holy Ghost this month? ---",
    "--- Who are some of your personal heroes? ---"};
    private List<string> _listedItems = new List<string> ();
    //constructor
    public Listing ()
    {
    
    }
    public Listing ( List<string> listOfPrompts, List<string> listedItems)
    {
        _listOfPrompts = listOfPrompts;
        _listedItems = listedItems;
    }
    //methods
    public void Intro()
    {
        Random random = new Random();
        int index = random.Next(_listOfPrompts.Count);
        string RandomPrompt = _listOfPrompts[index];

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(RandomPrompt);
        Console.Write("When you are ready, press enter to continue.");
        Console.ReadLine();
        for (int i = 5; i > -1; i--)
            {
                Console.Write($"\rYou may begin in: {i} "); 
                Thread.Sleep(1000); 
            }
        Console.WriteLine();
        

    }

    public void ListItems(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                _listedItems.Add(item);
            }
        int numberOfItems = _listedItems.Count;
        Console.WriteLine($"You listed {numberOfItems} items!");
    }

    public void RunListing()
    {
        Console.WriteLine("Welcome to the Listing activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        int duration = SetDuration();
        Console.WriteLine("Get Ready");
        PlayAnimation();
        Intro();
        ListItems(duration);
        EndMessage(duration, "Listing");
    }
}