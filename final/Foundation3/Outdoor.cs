public class Outdoor : Event
{
    //attributes
    private string _weather;
    //constructor
    public Outdoor()
    {
        
    }
    //methods
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public override string FullDetails()
    {
        string fullDetails= base.FullDetails();
        fullDetails += $"\nWeather Forecast: {_weather}\n";
        return fullDetails;
    }
}