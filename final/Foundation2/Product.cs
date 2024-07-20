public class Product
{
    private string _name;
    private string _id;
    private  double _price;
    private int _quantity;

    public Product (string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return Math.Round((_price * _quantity),2);
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{_name} ({_id}) => Total: ${CalculatePrice()}");
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetId()
    {
        return _id;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}