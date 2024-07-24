public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

     public Address(string street, string city, string state, string postalCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state} {_postalCode} {_country}\n";
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string streetAddress)
    {
        _street = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetPostalCode()
    {
        return _postalCode;
    }

    public void SetPostalCode(string postalCode)
    {
        _postalCode = postalCode;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}