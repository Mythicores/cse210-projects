using System.Runtime;
using System.Security.Cryptography;

public class Scripture
{
    private List<Word> _wordList;
    private string _reference;
    private string _fullScripture;

    public Scripture()
    {
        _wordList = new List<Word>();
        _fullScripture = "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—This is My Beloved Son. Hear Him!";
        FillWordList();
    }

    private string[] SplitScripture()
    {
        string[] splitScripture = _fullScripture.Split(" ");
        return splitScripture;
    }

    private void FillWordList()
    {
        string[] scriptureArray = SplitScripture();
        foreach (var item in scriptureArray)
        {
            Word word = new Word();
            word.SetWord(item);
            _wordList.Add(word);
        }
    }
    private string GetReference(string book, int chapter, int verse, int endVerse)
    {
        Reference scriptureReference = new Reference(book, chapter, verse, endVerse);
        string reference = scriptureReference.GetScripture();
        return reference;
    }
    public void Display(string book, int chapter, int verse, int endVerse)
    {
        Console.Clear();
        Console.WriteLine("");
        foreach (var item in _wordList)
        {
            Console.Write(item.DisplayWord() + " ");
        }
        Console.WriteLine("");
        Console.WriteLine(GetReference(book, chapter, verse, endVerse));
    }
    private int ChooseRandomNumber()
    {
        Random random = new Random();
        int listAmount = _wordList.Count();
        int randomNumber = random.Next(listAmount);
        return randomNumber;
    }
    public void HideRandomWord()
    {
        int randomAmount = ChooseRandomNumber();
        for (int i = 0; i < randomAmount; i++)
        {
            randomAmount = ChooseRandomNumber();
            int index = ChooseRandomNumber();
            // Set the word in the list "_wordList[index]" to hidden.
            _wordList[index].Hide();
            // The hiddenAmount is for the function AreAllHidden.
        }
    }

    public bool AreAllhidden()
    {
        int amountHidden = 0;
        foreach (Word word in _wordList)
        {
            if (word.IsItHidden() == true)
            {
                amountHidden += 1;
            }
        }
        if (amountHidden == _wordList.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}