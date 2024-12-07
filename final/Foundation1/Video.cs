using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments; // list of comment objects

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Methods

    // Title
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // Author
    public string GetAuthor()
    {
        return _author;
    }

    // Length
    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    // Add comment to list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Retrieve all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}