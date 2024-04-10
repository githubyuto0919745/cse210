public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public string Addresses
    { 
        get { return _address; }
        set { _address = value; }
    }
    public string City 
    { 
        get { return _city; }
        set { _city = value; }
    }
    public string State 
    { 
        get { return _state; }
        set { _state = value; }
    }
    public string Country 
    { 
        get { return _country; }
        set { _country = value; }
    }

    public Address()
    {
        
    }
    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public string DisplayAddress()
    {
        return $"{_address}\n {_city} {_state}{_country}";
    }
    public string ReturnCountry()
    {
        return _country;
    }
}