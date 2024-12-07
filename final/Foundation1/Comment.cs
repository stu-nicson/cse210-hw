public class Comment
{
    //attributes
    public string _name;
    public string _text;

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}