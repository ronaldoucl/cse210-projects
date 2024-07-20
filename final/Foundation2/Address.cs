public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\r\n{_city}, {_state}\r\n{_country}";
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }

    public void SetStreetAddress(string value)
    {
        _streetAddress = value;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
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
}