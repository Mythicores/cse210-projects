using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Scripture1
{
    private List<Word1> _scriptureWords;
    private Reference1 _reference;
    private string _scripture;


    public Scripture1()
    {
        _scriptureWords = new List<Word1>();
        _scripture = "I saw a pillar of light exactly over my head, above the brightness of the sun, which descended gradually until it fell upon me. It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, standing above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—This is My Beloved Son. Hear Him!";
    }

    public Scripture1(string book, int chapter, int verse, int endVerse)
    {
        _reference = new Reference1(book, chapter, verse, endVerse);
    }

    public string GetScripture()
    {
        string scripture = _scripture;
        return scripture;
    }

    public List<Word1> GetScriptureWordList()
    {
        return _scriptureWords;
    }

    public void PopulateWords(string scripture)
    {
        string[] list = scripture.Split(" ");
        foreach (var parts in list)
        {
            Word1 word = new Word1();
            word.SetWord(parts);
            _scriptureWords.Add(word);
        }
    }

    public void Displaytext()
    {
        foreach (var i in _scriptureWords)
        {
            Console.WriteLine(i.HiddenOrDisplay());
        }
    }
    private int ChooseRandomNumber()
    {
        Random random = new Random();
        int index = random.Next(_scriptureWords.Count);
        return index;
    }

    public void HideRandomWord()
    {
        for (int i = 0; i < 3; i++) {
            int index = ChooseRandomNumber();

            _scriptureWords[index].Hide();
        }
    }
}