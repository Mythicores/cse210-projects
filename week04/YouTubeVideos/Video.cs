using System.Net;

public class Video
{
    private string _title;
    private string _author;
    private int _length; //in seconds
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string comment)
    {
        Comment comment1 = new Comment(name, comment);
        _comments.Add(comment1);
    }

    public int GetVideoAmount()
    {
        return _comments.Count();
    }
    
    public void Display(Video video)
    {
        string display = $"{_title}\n{_author}:\n Length:{_length}\nComment Number: {GetVideoAmount()}";
        Console.WriteLine(display);
        DisplayAllComments();
    }

    public void DisplayAllComments()
    {
        Console.WriteLine($"{_author}\n-----\n\n");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"\n\n----------\n\n{comment.GetAuthor()}\n{comment.GetText()}\n\n----------\n\n");
        }
    }
}