public class Swimming : Activity
{
    //attributes
    private float _laps;
    //constructor
    public Swimming (string date, float time, float laps)
        : base (date, time, "Swimming")
        {
            _laps = laps;
        }
    //methods
    public float GetLaps()
    {
        return _laps;
    }
    public void SetLaps(float laps)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        return (_laps * 50) / 1609.34f;
    }

    public override float GetSpeed()
    {   
        return (GetDistance() / GetTime()) * 60;
    }

    public override float GetPace()
    {
        return GetTime() / GetDistance();
    }
}