using System.IO;

public class Prompt
{

    public string _repeatingPrompt = @"
    Select one of the following options:
    1. Write
    2. Display
    3. Load
    4. Save
    5. Quit";
    public List<string> _randomPrompts;
    public string _response;
    public Prompt()
    {
        string WritePrompts = "WritePrompts.txt";
        _randomPrompts = new List<string>(System.IO.File.ReadAllLines(WritePrompts));
    }

    public void DisplayRepeatingPrompt()
    {
        Console.WriteLine(_repeatingPrompt);
    }

    public void GenerateRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_randomPrompts.Count);
        _response = _randomPrompts[index];
        Console.WriteLine(_response);
    }
    
}