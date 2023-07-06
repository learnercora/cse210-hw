using System;

public class Comment
{
    public string _person = "";
    public string _commentText = "";

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"Person:{_person} / Comment:{_commentText}");
    }

}