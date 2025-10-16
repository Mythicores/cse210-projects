using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square s = new Square(2);
        s.SetColor("blue");
        Rectangle r = new Rectangle(2, 2);
        r.SetColor("green");
        Circle c = new Circle(2);
        c.SetColor("red");
        List<Shape> shapeList = CreateList(s, r, c);
        foreach (var i in shapeList)
        {
            Console.WriteLine(i.GetColor());
            Console.WriteLine(i.GetArea());
        }
    }
    static List<Shape> CreateList(Square square, Rectangle rect, Circle circle)
    {
        List<Shape> list = new List<Shape>();
        list.Add(square);
        list.Add(rect);
        list.Add(circle);
        return list;
    }
}