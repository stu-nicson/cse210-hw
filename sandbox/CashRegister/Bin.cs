class Bin
{
    //attributes
    private string _denomination;
    private float _value;
    private int _quantity;


    // methods
    //this first one is a constructor
    public Bin(string denomination, float value, int quantity)
    {
        _denomination = denomination;
        _value = value;
        _quantity = quantity;
    }
    public void ModifyQuantity(int exchange)
    {
        _quantity += exchange;
    }
    public float CountValue()
    {
        return _quantity * _value;
    }
}