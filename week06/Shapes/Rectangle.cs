using System.ComponentModel.DataAnnotations;

public class Rectangle : Shape
{
    private int _length;
    private int _height;

    public Rectangle(int length, int height) : base()
    {
        _length = length;
        _height = height;
    }

    public int GetLength()
    {
        return _length;
    }
    public int GetHeight()
    {
        return _height;
    }

    public override int GetArea()
    {
        int height = GetHeight();
        int length = GetLength();
        return length * height;
    }
}