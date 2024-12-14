public class Lecture : Event
{
    //attributes
    private string _speaker;
    private string _capacity;
    //constructor
    public Lecture()
    {
        
    }
    //methods
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public string GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }
    public override string FullDetails()
    {
        string fullDetails= base.FullDetails();
        fullDetails += $"\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
        return fullDetails;
    }
}
