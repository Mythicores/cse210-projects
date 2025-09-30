using System.Collections.Concurrent;

public class Reference1
{
    private int _chapter;
    private int _verse;
    private int? _endVerse;
    private string _book;

    public Reference1()
    {
        _book = "Nephi";
        _chapter = 1;
        _verse = 1;
        _endVerse = null;
    }

    public Reference1(string book, int chapter, int verse, int? endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse ?? verse;
    }

    public string GetDisplayedReference()
    {
        string DisplayedReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        if (_endVerse == _verse)
        {
            DisplayedReference = $"{_book} {_chapter}:{_verse}";
        }
        return DisplayedReference;
    }
}