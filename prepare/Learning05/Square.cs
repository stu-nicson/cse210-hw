using System.Drawing;

public class Square : Shape
{
    // attributes
    private double _side;
    //constuctor
    public Square(string color, double side) : base(color)
    {
        _side = side;        
    }
    //methods
    public override double GetArea()
        {
            return _side * _side;
        }

}