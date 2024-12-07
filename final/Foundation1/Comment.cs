public class Comment
{
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Getter and setter for commenter name
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    // Getter and setter for comment text
    public string GetCommentText()
    {
        return _commentText;
    }
    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }
}