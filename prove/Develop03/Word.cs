using System;

//Keeps track of a single word and whether it is shown or hidden.
public class Word 
{
     //Attributes
    private string _word;
    private bool _isShown = true;
    

    //Constructor
    public Word(string word)
    {
        _word = word;
    }
    
    //Behaviors
    public string GetWord() //GetRenderedText
    {
        string output = _word;
        return output;
    }

    public void Hide()
    {
        _isShown = false;
    }
    public void Show()
    {
        _isShown = true;
    }

    public bool IsHidden()
    {
        return _isShown;
    }

}