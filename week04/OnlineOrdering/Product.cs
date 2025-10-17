public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string customerName, int productID, double price, int quantity)
    {
        _name = customerName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductID()
    {
        return _productID;
    }

    private double CalculateTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }
    
    public double GetTotalCost()
    {
        return CalculateTotalCost();
    }
}