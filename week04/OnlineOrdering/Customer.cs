public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address = new Address(_name, streetAddress, city, state, country);
        
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        string address = _address.GetAddress();
        return address;
    }
    public bool IsInUS()
    {
        if (_address.InUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}