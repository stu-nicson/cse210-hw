using System.IO; 

public class Journal
{
    public List<string>  _prompts = new List<String> () 
    {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is one thing you learned today?", "What are three things you are grateful for today?"};
    public List<Entry> _entries = new List<Entry> ();
    public void inputEntry()
    {
        Entry entry = new Entry();
        entry._prompt = promptGenerator();
        Console.WriteLine(entry._prompt);
        Console.Write("> "); 

        entry._response = Console.ReadLine();

        entry._dateTime = DateTime.Now.ToShortDateString();

        _entries.Add(entry);
    }

    public string promptGenerator()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];
        return selectedPrompt;
    }

    public void displayJournal()
    {
       foreach (Entry entry in _entries)
       {
            entry.DisplayEntry();
       } 
       
    }

    public void writeEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateTime}~{entry._prompt}~{entry._response}");
            } 
            
        }
    }

    public void readEntries(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry entry = new Entry();

            entry._dateTime = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}