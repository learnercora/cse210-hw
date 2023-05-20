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

    //Constructor
    public Scripture(string reference, string textOfScripture)
    {
        _reference = reference;
        _textOfScripture = textOfScripture;
    }
    
    //Behaviors
    public string GetTextOfScripture() //GetRenderedText
    {
        //Console.Clear();
        string output = $"{_reference} {_textOfScripture}";
        return output;
    }

    public void HideWords()
    {
        string newTextOfScripture = "";
        string[] words = _textOfScripture.Trim().Split(' ');

        Random random = new Random();

        //依據hideNum找出數個words中的單字
        int hideNum = random.Next(3,6); //取得要隱藏的字數
        int i = 0;
        while(i < hideNum) 
        {
            int hideIndex = random.Next(words.Length);
            //Console.WriteLine(hideIndex);
            if (!_hideIndexList.Contains(hideIndex))
            {
                _hideIndexList.Add(hideIndex);
                _hideIndexList.Sort(); 

                //處理若隨機數hideNum大於等於剩下未隱藏的單字
                int restWordNum = words.Length - _hideIndexList.Count;
                if (!(hideNum < restWordNum))
                {
                    hideNum = restWordNum;
                }
                // Console.WriteLine("restWordNum");
                // Console.WriteLine(restWordNum);

                i++;
            }   
        }
        // Console.WriteLine("_hideIndexList.Count");
        // Console.WriteLine(_hideIndexList.Count);
        // Console.WriteLine("hideNum");
        // Console.WriteLine(hideNum);
        //Console.WriteLine(string.Join(", ", _hideIndexList));

        //把random的字變成＿
        for (int j = 0 ; j < words.Length ; j++ ) 
        {
            if (_hideIndexList.Contains(j))
            {
                //Console.WriteLine(words[j]);
                char lastWordCharacter = words[j][words[j].Length-1];

                if (words[j].EndsWith(".") || words[j].EndsWith(";") || words[j].EndsWith(","))
                {
                    //Console.WriteLine(words[j]);
                    newTextOfScripture += new string('_', words[j].Length-1) + lastWordCharacter.ToString() + " ";
                }
                else
                {
                    newTextOfScripture += new string('_', words[j].Length) + " ";
                }
            }
            else
            {
                newTextOfScripture += words[j] + " ";
            }
        }

        _textOfScripture = newTextOfScripture;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = false;
        // ** method 1 **
        // int countChar = 0;

        // for (int i = 0 ; i < _textOfScripture.Length ; i++ )
        // {
        //     string regexRule = "[a-zA-Z]";
        //     if (Regex.IsMatch(_textOfScripture[i].ToString(),regexRule))
        //     {
        //         //Console.WriteLine(_textOfScripture[i]);
        //         countChar += 1;
        //     }
        // }
        // if (countChar == 0)
        // {
        //     isCompletelyHidden = true;
        // }

        // ** method 2 **
        string[] words = _textOfScripture.Trim().Split(' ');
        int wordsLength = words.Length;
        if (_hideIndexList.Count == wordsLength)
        {
            isCompletelyHidden = true;
        }
        return isCompletelyHidden;
    }

    


}