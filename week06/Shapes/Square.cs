using System.Formats.Asn1;

public class Square : Shape
{
    int _side;
    public Square(int side) : base()
    {
        _side = side;
    }

    public void SetSide(int side)
    {
        _side = side;
    }
    public int GetSide()
    {
        return _side;
    }

    public override int GetArea()
    {
        return _side * _side;
    }
}