public class Product
{
    //attributes
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    //constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    //methods
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public decimal TotalCost()
    {
        return _quantity * _price;
    }

   
}