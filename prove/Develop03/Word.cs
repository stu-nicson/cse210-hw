public class Word
{
    //attributes
    private string _word;
    private bool _isHidden;

    public Word ( string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    public void Hide()
    {
        _word = "___";
        _isHidden = true;

    }
    //Add getters and setters
    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void SetIsHidden( bool isHidden)
    {
        _isHidden = isHidden;
    }

}