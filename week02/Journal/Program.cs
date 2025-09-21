using System;
using System.Net;
/// I added a feature that always creates and uses a temporary file "ContemporaryFile" to store the info, unless files are loaded in or if the user decides to save it to another file.
class Program
{
    static void Main(string[] args)
    {
        string saveFile = "Save.txt";
        string contemporaryFile = "ContemporaryFile.txt";
        Prompt write1 = new Prompt();
        Console.WriteLine("Welcome to my Journal project! Sit back! Relax, and select one of the following options:");
        write1.DisplayRepeatingPrompt();
        string optionSelected = Console.ReadLine();
        optionSelected = optionSelected.ToLower();

        
        //1. Write
        while (optionSelected != "5" && optionSelected != "quit")
        {
            if (optionSelected == "1" || optionSelected == "write")
            {//1.Write
                write1.GenerateRandomPrompt();
                //Format and save the response
                JournalEntry entry1 = new JournalEntry();
                entry1._journalEntry = Console.ReadLine();
                string formattedEntry = entry1.FormatEntry(entry1._journalEntry, write1._response);
                entry1.SaveJournalEntry(formattedEntry, contemporaryFile);
                write1.DisplayRepeatingPrompt();
                optionSelected = Console.ReadLine();

                //3. Load
                //4. Save
                //5. Quit
            }
            if (optionSelected == "2" || optionSelected == "display")
            {//2. Display
                JournalEntry display = new JournalEntry();
                display.DisplayAllEntries(contemporaryFile);
                write1.DisplayRepeatingPrompt();
                optionSelected = Console.ReadLine();
            }
            if (optionSelected == "3" || optionSelected == "load")
            {
                Console.WriteLine("Which file would you like to load?");
                saveFile = Console.ReadLine();
                contemporaryFile = saveFile;
                Console.WriteLine("File loaded.");
                
                write1.DisplayRepeatingPrompt();
                optionSelected = Console.ReadLine();
            }
            if (optionSelected == "4" || optionSelected == "save")
            {
                NewFile overwriteFile = new NewFile();

                    Console.WriteLine("Which file would you like to save?");
                    string filename = Console.ReadLine();
                    overwriteFile.OverwriteFile(contemporaryFile, filename);
                    Console.WriteLine("File saved.");

                write1.DisplayRepeatingPrompt();
                optionSelected = Console.ReadLine();
            }
        }
        if (contemporaryFile == "ContemporaryFile.txt")
        {
            File.WriteAllText(contemporaryFile, string.Empty);
        }
        Console.WriteLine("Thanks for using this program!");
    }
}