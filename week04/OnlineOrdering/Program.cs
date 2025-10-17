using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order1 = new Order("Billy Goodner", "State Street", "Salt Lake", "Utah", "United States");
        order1.AddProduct("Toy car", 5, 1);
        order1.AddProduct("Choo choo train", 2, 10);
        order1.Run();
    }
}