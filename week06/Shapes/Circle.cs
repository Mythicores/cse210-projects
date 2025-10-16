using System.Formats.Asn1;

public class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI;
    public Circle(int radius) : base()
    {
        _radius = radius;
    }

    public override int GetArea()
    {
        double area = _pi * Math.Pow(_radius, 2);
        area = Math.Floor(area);
        return (int)area;
    }
}