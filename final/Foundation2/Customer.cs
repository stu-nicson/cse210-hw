public class Customer
{
    //attributes
    private string _customerName;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    //methods
    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool IsInUSA()
    {
        return _address.GetCountry() == "USA";
    }
}