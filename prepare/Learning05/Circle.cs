public class Cirlce : Shape
{
    //attributes
    private double _radius;
    //constructor
    public Cirlce( string color, double radius) : base(color)
    {
        _radius = radius;
    }
    //methods
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;;
    }
}

