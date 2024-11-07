//Name
public class Reference
{
    //attributes
    private string _book;
    private string _chapter;
    private string _startverse;
    private string _endverse;
    //Constructor
    public Reference(string book, string chapter, string startverse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    //methods
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public string GetStartVerse()
    {
        return _startverse;
    }
    public string GetEndVerse()
    {
        return _endverse;
    }
    
    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_startverse}-{_endverse}");
    }

}