public class Order
{
    //attributes
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    //methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal OrderCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

     public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}, Product ID: {product.GetProductId()} Price: {product.GetPrice()}, Quantity: {product.GetQuantity()}\n" ;
        }
        
        return label;
    }

    public string ShippingLabel()
    {
        Customer customer = _customer;
        string address = _customer.GetAddress().DisplayAddress();

        return $"Name: {customer.GetCustomerName()}\nAddress:\n{address}";
    }
}