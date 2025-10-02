using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment homework = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(homework.GetSummary());
        Console.WriteLine();
        MathAssignment mathHomework = new MathAssignment("Robert Rodrigez", "Fractions", 7.3, "18-19");
        Console.WriteLine(mathHomework.GetHomeWorkList());
        Console.WriteLine();
        WritingAssignment writingHomework = new WritingAssignment("Amelia Earlhart", "Civil War History", "The historical effects of the Civil War", "Mr. Beck");
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}