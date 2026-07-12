using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    
    public List<Comment> _comments = new List<Comment>();

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine($"Video Title : {_title}");
        Console.WriteLine($"Author/Chan : {_author}");
        Console.WriteLine($"Length      : {_lengthInSeconds} seconds");
        Console.WriteLine($"Total Comm. : {GetCommentCount()}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Comments List:");
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("==================================================\n");
    }
}