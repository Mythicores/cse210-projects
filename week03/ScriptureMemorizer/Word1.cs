using System.Reflection.PortableExecutable;

public class Word1
{
    private bool _isHidden;
    private string _text;

    
    public Word1()
    {
        _isHidden = false;
        _text = "Error";
    }


    public void SetWord(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string HiddenOrDisplay()
    {

        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            string hiddenWord = "";
            foreach (var character in _text)
            {
                hiddenWord += "_";


                // Figure out how to iterate through each letter and return underscore.
            }
            return hiddenWord;
        }
    
    }
}