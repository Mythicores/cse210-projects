public class Resume
{
    public Resume()
    {
    }
    public string _name = "";
    public List<Job> _jobs = [];

    public void DisplayResume()
    {
        Console.WriteLine($"{_name}");
        foreach (Job i in _jobs)
        {
            i.DisplayJobDetails();
        }
    }
}