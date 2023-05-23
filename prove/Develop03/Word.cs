using System;

//Keeps track of a single word and whether it is shown or hidden.
public class Word 
{
     //Attributes
    private string _word;
    private bool _isHide = false;
    

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
        _isHide = true;
    }
    public void Show()
    {
        _isHide = false;
    }

    public bool IsHidden()
    {
        return _isHide;
    }

}