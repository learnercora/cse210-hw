using System;

//Keeps track of the book, chapter, and verse information.
public class Reference 
{
    //Attributes
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    
    //Constructor
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Behaviors
    public string GetReference() //GetRenderedText
    {
        string output = "";

        if (_endVerse == "")
        {
            output =$"{_book} {_chapter}:{_verse}";
        }
        else
        {
            output =$"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return output;
    }

}