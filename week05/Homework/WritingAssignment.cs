using System.Dynamic;

public class WritingAssignment : Assignment
{
    string _assignmentTitle;
    string _author;

    public WritingAssignment(string name, string topic, string assignmentTitle, string author) : base(name, topic)
    {
        _assignmentTitle = assignmentTitle;
        _author = author;
    }

    public string GetWritingInformation()
    {
        string summary = $"{GetName()} - {GetTopic()}";
        string writingInformation = $"{summary}\n{_assignmentTitle} by {_author}";
        return writingInformation;
    }
}