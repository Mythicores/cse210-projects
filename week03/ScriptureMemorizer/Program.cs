using System;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

class Program
{
    static void Main(string[] args)
    {
        string action = "begin";
        Scripture firstVision = new Scripture();

        while (action != "quit")
        {
            firstVision.Display("Joseph Smith-History", 1, 16, 17);
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            action = Console.ReadLine();
            if (action == "")
            {
                firstVision.HideRandomNumber();
            }
            if (firstVision.AreAllhidden() == true)
            {
                action = "quit";
            }
        }
    }
}