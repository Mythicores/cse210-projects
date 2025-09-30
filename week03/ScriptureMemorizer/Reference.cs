public class Reference
{
    string _scripture;
    string _book;
    int _chapter;
    int _verse;
    int? _endVerse;

    public Reference()
    {
        _endVerse = null;
    }
    public Reference(string book, int chapter, int verse, int? endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse ?? verse;
    }

    public string GetScripture()
    {
        if (_endVerse == _verse)
        {
            string scripture = $"{_book} {_chapter}:{_verse}";
            return scripture;
        }
        else
        {
            string scripture = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return scripture;
        }
    }


}