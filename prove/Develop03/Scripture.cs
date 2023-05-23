using System;
using System.Text.RegularExpressions;

//Keeps track of the reference and the text of the scripture. 
//Can hide words and get the rendered display of the text.
public class Scripture 
{
    //Attributes
    private string _reference;
    //private List<string> _words;
    private string _textOfScripture;
    private List<int> _hideIndexList = new List<int>();
    private List<Word> _wordList = new List<Word>();
    
    //Constructor
    public Scripture(string reference, string textOfScripture)
    {
        _reference = reference;
        _textOfScripture = textOfScripture;
        string[] words = _textOfScripture.Trim().Split(' ');
        for(int i = 0; words.Length > i; ++i)
        {
            _wordList.Add(new Word(words[i]));
        }
    }
    
    //Behaviors
    public string GetTextOfScripture() //GetRenderedText
    {
        Console.Clear();
        string output = $"{_reference} {_textOfScripture}";
        return output;
    }

    public void HideWords()
    {
        Random random = new Random();
        string newTextOfScripture = "";

        int restWordNum = _wordList.Count - _hideIndexList.Count;

        //依據hideNum找出數個words中的單字
        int hideNum = random.Next(3,6); //取得要隱藏的字數
        if ((restWordNum - hideNum) < hideNum) //處理若隨機數hideNum大於等於剩下未隱藏的單字
        {
            hideNum = restWordNum;
        }

        int i = 0;
        while ( i < hideNum )
        {
            int hideIndex = random.Next(_wordList.Count);
            if (!_hideIndexList.Contains(hideIndex))
            {
                _wordList[hideIndex].Hide(); //call Hide()method in Word class

                _hideIndexList.Add(hideIndex); //record hide Index List
                _hideIndexList.Sort(); 

                i++;
            }
        }
        
        // for(int i = 0; i < hideNum ; i++) 
        // {
        //     int hideIndex = random.Next(_wordList.Count);

        //     _wordList[hideIndex].Hide();
        // }
        
        
        //把random的字變成＿
        for (int j = 0 ; j < _wordList.Count ; j++ ) 
        {
            if(_wordList[j].IsHidden())
            {
                string word = _wordList[j].GetWord();
                char lastWordCharacter = word[word.Length-1];
                if (word.EndsWith(".") || word.EndsWith(";") || word.EndsWith(","))
                {
                    newTextOfScripture += new string('_', word.Length-1) + lastWordCharacter.ToString() + " ";
                }
                else
                {
                    newTextOfScripture += new string('_', word.Length) + " ";
                }
            }
            else
            {
                newTextOfScripture += _wordList[j].GetWord() + " ";
            }
        }

        _textOfScripture = newTextOfScripture;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;

        for(int i = 0; _wordList.Count > i; ++i)
        {
            if(_wordList[i].IsHidden() == false){
                isCompletelyHidden = false;
                break;
            }
        }
        return isCompletelyHidden;
    }
    
}
