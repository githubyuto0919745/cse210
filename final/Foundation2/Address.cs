public class Address
{
    public  string _address {get;set;}
    public string _city {get;set;}
    public string _state {get;set;}
    public string _country {get;set;}

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