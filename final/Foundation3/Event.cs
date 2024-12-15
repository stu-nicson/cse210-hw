public class Event
{
    //attributes
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;


    //constructor
    public Event()
    {

    }
    public Event(string eventType, string title, string description, string date, string time, 
    Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    //methods
    public string GetEvent()
    {
        return _eventType;
    }
    public void SetEvent(string eventType)
    {
        _eventType = eventType;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
     public string GetTime()
    {  
        return _time;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }


    public string StandardDetails()
    {
        string standardDetails = $"Standard Details\n------------------\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}\n";
        return standardDetails;
    }

    public string ShortDescription()
    {
        string shortDescription = $"Short Description\n------------------\nEvent: {_eventType}\nTitle: {_title}\nDate: {_date}\n";
        return shortDescription;
    }

    public virtual string FullDetails()
    {
        string fullDetails = $"Full Details\n------------------\nEvent: {_eventType}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
        return fullDetails;
    }
}