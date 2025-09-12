using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("What's your last name?");
        string last_name = Console.ReadLine();
        string combined = first_name + " " + last_name;

        Console.WriteLine($"Your name is {last_name}, {combined}");
    }
}