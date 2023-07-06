using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _lengthInSec = 0;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSec = length;
        _comments = new List<Comment>();
    }
    public void AddComment(string person, string text)
    {
        Comment comment = new Comment
        {
            _person = person,
            _commentText = text
        };
        _comments.Add(comment);
    }


    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSec.ToString()}");
        Console.WriteLine($"Number of Comments: {GetNumComments().ToString()}");
        Console.WriteLine("Comment Details:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentDetails();
        }
    }

}