using System.Reflection;
using System.Transactions;

public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment>comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Getcomment(Comment text)
    {
        comments.Add(text);
    }
    public string CommentAmount()
    {
        return $"Amount of comments: {comments.Count}";
    }
    public void DisplayComments()
    {
        foreach (Comment comment in comments)
        {
            System.Console.WriteLine($"{comment._person}: {comment._text}");
        }
    }
    public void Display()
    {
        System.Console.WriteLine($"Title: {_title}, author: {_author}, duration of video: {_length} seconds ");
    }
}

