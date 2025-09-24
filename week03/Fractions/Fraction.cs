using System.Diagnostics;
using System.Dynamic;
using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;

    }
    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public string GetFractionString()
    {
        string fraction = $"{_topNumber}/{_bottomNumber}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }


}