using System.Formats.Asn1;

public class Shape
{
    private string _color;

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public virtual int GetArea()
    {
        return 0;
    }
}