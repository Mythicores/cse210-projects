public class JournalEntry() //Remember, Classes are things! They can do certain things (methods) and have characteristics. (for a video game character think weight, or speed).
{

    public string _journalEntry = ""; //Think of the attributes as "Things ready to be filled in". They are, like a template, the text box ready to be filled in.
    //They're that section that says something like "Enter your SSN here". The text box would have the attribute SSN, and it's ready to be filled in with a new number.

    public string _loadedFile = "";
    public string FormatEntry(string _journalEntry, string response)
    {
        string date = DateTime.Now.ToString("ddMMMyyyy");
        string originalEntry = _journalEntry;
        string formattedEntry = $"Date: {date} - Prompt: {response} \n {_journalEntry}";
        return formattedEntry;
    }
    public void SaveJournalEntry(string _journalEntry, string fileString)
    {
        string _loadedFile = fileString;
        using (StreamWriter outputFile = new StreamWriter(_loadedFile, true))
        {
            outputFile.WriteLine(_journalEntry);
        }
    }
    public void DisplayAllEntries(string saveFile)
    {
        string SaveFile = saveFile;
        List<string> allEntries = new List<string>(System.IO.File.ReadAllLines(SaveFile));
        foreach (string line in allEntries)
        {
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}