using System.Diagnostics;

public class Running : Activity
{
    //attributes
    private float _distance;
    //constructor
    public Running(string date, float time, float distance)
        : base (date, time, "Running")
    {
        _distance = distance;
    }
    //methods

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / GetTime()) * 60;
    }

    public override float GetPace()
    {
        return GetTime() / _distance;
    }

}