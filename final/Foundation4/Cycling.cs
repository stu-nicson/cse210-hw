public class Cycling : Activity
{
    //attributes
    private float _speed;
    //constructor
    public Cycling(string date, float time, float speed)
        : base (date, time, "Cycling")
    {
        _speed = speed;
    }
    //methods
    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

}