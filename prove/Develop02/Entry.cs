public class Entry
{
    public string _dateTime;
    public string _response;
    public string _prompt;

    public void DisplayEntry()
    {
        //DateTime theCurrentTime = DateTime.Now;
        //string _dateTime = theCurrentTime.ToShortDateString();
        //This will just be a formatted line to display each one of the above attributes. 
        Console.WriteLine($"Date:{_dateTime} Prompt:{_prompt} \n {_response}");
    }

}

