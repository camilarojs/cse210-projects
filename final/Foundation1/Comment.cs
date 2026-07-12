using System;

class Comment
{
    public string _commenterName;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"  - {_commenterName}: \"{_commentText}\"");
    }
}