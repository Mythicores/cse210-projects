using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity activity = new Activity();
        Console.WriteLine(activity.Menu());
        string userChoice = Console.ReadLine().ToLower();
        while (userChoice != "quit" || userChoice != "4") {
            if (userChoice == "1")
            {
                Console.Clear();
                Breathing breathing = new Breathing(10);
                Console.WriteLine(breathing.FullIntro());
                string sessionLength = Console.ReadLine();
                breathing.SetSessionLength(int.Parse(sessionLength));
                breathing.Run();

                Console.Clear();
                Console.WriteLine(activity.Menu());
                userChoice = Console.ReadLine();
            }
            if (userChoice == "2")
            {
                Console.Clear();
                Reflecting reflectingActivity = new Reflecting(0);
                reflectingActivity.Run();
                Console.Clear();
                Console.WriteLine(activity.Menu());
                userChoice = Console.ReadLine();
            }
            if (userChoice == "3")
            {
                Console.Clear();
                Listing listingActivity = new Listing(0);
                listingActivity.Run();
                Console.Clear();
                Console.WriteLine(activity.Menu());
                userChoice = Console.ReadLine();
            }
            if (userChoice == "4")
            {
                Console.Clear();
                Console.WriteLine("\n\nThank you for using this program!");
                break;
            }
        }
    }
}