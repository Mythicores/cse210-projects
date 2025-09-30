public class Word
{
    bool _hidden;
    string _text;


    public Word()
    {
        _hidden = false;
    }
    public void SetWord(string word)
    {
        _text = word;
    }
    private string HideWord()
    {
        string hiddenWord = "";
        foreach (var i in _text)
        {
            hiddenWord += "_";
        }
        return hiddenWord;
    }
    public string DisplayWord()
    {
        if (_hidden == true)
        {
            string hiddenWord = HideWord();
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
    public void Hide()
    {
        _hidden = true;
    }

    public bool IsItHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}