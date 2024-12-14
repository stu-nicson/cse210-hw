public abstract class Activity
{
    //attributes
    private string _date;
    private float _time;
    private string _activityName;
    //constructor
    public Activity(string date, float time, string activityName)
    {
        _date = date;
        _time = time;
        _activityName = activityName;
    }
    //methods
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }

    public float GetTime()
    {
        return _time;
    }
    public void SetTime(float time)
    {
        _time = time;
    }

    public string GetName()
    {
        return _activityName;
    }
    public void SetName(string name)
    {
        _activityName = name;
    }

    public virtual float GetDistance()
    {
        return 0;
    }
    public virtual float GetSpeed()
    {
        return 0;
    }
    public virtual float GetPace()
    {
        return 0;
    }


    public virtual string DisplaySummary()
    {
        return $"{_date} {_activityName} ({_time} min) - Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}