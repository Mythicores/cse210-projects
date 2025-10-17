public class Address
{
    //attributes
    private string _address;
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    //constructor
    public Address(string customerName, string streetAddress, string city, string state, string country)
    {

        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _address = CreateAddress(customerName);
    }

    //methods
    public string CreateAddress(string customerName)
    {
        string address = $"{customerName}\n{_streetAddress}\n{_city},{_state}\n{_country}";
        return address;
    }
    public string GetAddress()
    {
        return _address;
    }
    public bool InUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "america" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}