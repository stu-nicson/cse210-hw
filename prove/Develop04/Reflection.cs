public class Reflection : Activity
{
    //attributes
    private List<string> _prompt = new List<string>
    {"--- Think of a time when you stood up for someone else. ---",
    "--- Think of a time when you did something really difficult. ---",
    "--- Think of a time when you helped someone in need. ---",
    "--- Think of a time when you did something truly selfless. ---"};
    private List<string> _promptQuestions = new List<string>
    {"> Why was this experience meaningful to you?",
    "> Have you ever done anything like this before?",
    "> How did you get started?",
    "> How did you feel when it was complete?",
    "> What made this time different than other times when you were not as successful?",
    "> What is your favorite thing about this experience?",
    "> What could you learn from this experience that applies to other situations?",
    "> What did you learn about yourself through this experience?",
    "> How can you keep this experience in mind in the future?" };

    //constructor 
    //Do I need this constructor?
    public Reflection ()
    {
    
    }
    public Reflection ( List<string> prompt, List<string> promptQuestions)
    {
        _prompt = prompt;
        _promptQuestions = promptQuestions;
    }
    //methods
    public void Prompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        string RandomPrompt = _prompt[index];

        Console.WriteLine("Consider the Following Prompt: ");
        Console.WriteLine();
        Console.WriteLine(RandomPrompt);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        for (int i = 5; i > -1; i--)
            {
                Console.Write($"\rYou may begin in: {i} "); 
                Thread.Sleep(1000); 
            }
        Console.Clear();
        
    }
    public void Reflect(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

            while (DateTime.Now < endTime)
            {
                int index = random.Next(_promptQuestions.Count);
                string RandomPromptQuestion = _promptQuestions[index];
                Console.Write(RandomPromptQuestion);

                DateTime animationEndTime = DateTime.Now.AddSeconds(15);
                while (DateTime.Now < animationEndTime) 
                {
                    PlayAnimation15();
                }
                Console.WriteLine();
            }
        Console.WriteLine();
    }
    public void RunReflection()
    {
        Console.WriteLine("Welcome to the Reflection Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();

        int duration = SetDuration();
        Console.WriteLine("Get Ready");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.Clear();
                Console.WriteLine("Get ready...");
                PlayAnimation();
                Console.WriteLine("");
                Prompt();
                Reflect(duration);
                EndMessage(duration, "Reflection");
            }        



    }
    
}