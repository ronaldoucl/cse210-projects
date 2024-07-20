public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }


    public double GetShippingCost()
    {
        double shippingCost;
        if (_address.GetCountry() == "USA")
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_customerName}\r\n{_address.GetAddress()}\n");
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string value)
    {
        _customerName = value;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address value)
    {
        _address = value;
    }
}