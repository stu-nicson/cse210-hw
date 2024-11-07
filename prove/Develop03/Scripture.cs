public class Scripture
{
    //attributes
    private Reference _reference = new Reference("Proverbs", "3", "5", "6");
    private List<Word> _listOfWords = new List<Word> ();
    private Random _random;
    //Constructor
    public Scripture()
    {
        _random = new Random();
    }
    public Scripture( Reference reference)
    {
        _reference = reference;
    }
    //methods
    public void DisplayScripture()
    {
        //Loop through list of words and use GetWord()
        _reference.DisplayReference();
        foreach (var word in _listOfWords)
        {
            Console.Write(word.GetWord());
            Console.Write(" ");
        } 
        Console.WriteLine();
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _listOfWords)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideThreeWords()
    {
        //Use random index call _listOfWords[Random].Hide()
        
        int wordsHidden = 0;
        while (wordsHidden < 3)
        {
            int iRandom = GenerateRandomIndex(_listOfWords.Count());

            if (! _listOfWords[iRandom].GetIsHidden())
            {
                _listOfWords[iRandom].Hide();
                wordsHidden++;
            }

        }
    }

    public int GenerateRandomIndex(int listLength)
    {
        //returns a random index
        int i =_random.Next(0,listLength); 
        return i;
    }

    public void ParseText(string scriptureText)
    {
        string[] wordsArray = scriptureText.Split(" ");
        foreach (var word in wordsArray)
        {
            Word w = new Word(word, false); 
            _listOfWords.Add(w);
        }
    }
}