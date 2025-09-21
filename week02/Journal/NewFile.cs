public class NewFile()
{
    public string _savedFile = "";

    public void OverwriteFile(string source, string filename)
    {
        string file = filename;

        List<string> allEntries = new List<string>(System.IO.File.ReadAllLines(source));

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string line in allEntries)
            {
                outputFile.WriteLine(line);
            }
        }
        
        
    }

    public void SaveFile(string source, string filename)
    {
        string file = filename;

        List<string> allEntries = new List<string>(System.IO.File.ReadAllLines(source));

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string line in allEntries)
            {
                outputFile.WriteLine(line);
            }
        }
    }
}