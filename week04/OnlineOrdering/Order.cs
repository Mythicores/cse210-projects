using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _customer;

    public Order(string name, string streetAddress, string city, string state, string country)
    {
        _customer = new Customer(name, streetAddress, city, state, country);
    }

    public void AddProduct(string name, double price, int quantity)
    {
        Product product = new Product(name, 114523, price, quantity);
        _products.Add(product);
    }
    private double CalculateTotalCost()
    {
        double totalCost = 0.0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += CalculateShippingCost();
        return totalCost;
    }

    private double CalculateShippingCost()
    {
        double shippingCost = 0.0;
        if (_customer.IsInUS() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    private string CreatePackingLabel()
    {
        string packingLabel = $"\n--------------------\n\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductID()}-{product.GetName()}:\n";
        }
        packingLabel += "\n--------------------\n\n";
        return packingLabel;
    }
    private string CreateShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n----------\n{_customer.GetAddress()}";
        return shippingLabel;
    }
    public void Run()
    {
        Console.WriteLine($"Cost: ${CalculateTotalCost()}");
        Console.WriteLine(CreatePackingLabel());
        Console.WriteLine(CreateShippingLabel());
    }
}