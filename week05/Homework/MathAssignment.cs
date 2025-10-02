public class MathAssignment : Assignment
{

    private double _textbookSection;
    private string _problems;
    public MathAssignment(string name, string topic, double textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        string summary = GetSummary();
        string homeworkList = $"{summary}\nSection {_textbookSection} Problems {_problems}";
        return homeworkList;
    }

}