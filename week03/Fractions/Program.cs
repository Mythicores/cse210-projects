using System;

class Program
{
    static void Main(string[] args)
    {
        // Ensuring functions work
        Fraction defaults = new Fraction();
        Console.WriteLine($"Top default: {defaults.GetTopNumber()} Bottom default: {defaults.GetBottomNumber()}");
        Fraction wholeNumber = new Fraction(5);
        Console.WriteLine($"Top whole number: {wholeNumber.GetTopNumber()} Bottom whole number: {wholeNumber.GetBottomNumber()}");
        Fraction manual = new Fraction(4, 5);
        Console.WriteLine($"Top number: {manual.GetTopNumber()} Bottom number: {manual.GetBottomNumber()}");

        Fraction fraction = new Fraction(4, 5);
        Console.WriteLine($"Fraction 4/5 = {fraction.GetFractionString()}");

        Console.WriteLine("Decimal 4/5 = " + fraction.GetDecimalValue());

        Fraction f1 = new Fraction(1, 2);
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(90, 100);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
    }
}