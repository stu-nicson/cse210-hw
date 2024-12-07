public class Video
{
    //attributes
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _Comments = new List<Comment>();    

    public string ReturnCommentCount()
    {
        return _Comments.Count.ToString();
    }

    public void DisplayVideo()
    {
        string numberOfComments = ReturnCommentCount();
        Console.WriteLine("Video: ");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in seconds): {_length}");
        Console.WriteLine($"Number of Comments: {numberOfComments}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }
}