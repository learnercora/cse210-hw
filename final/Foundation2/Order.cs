using System;

public class Order 
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0 ;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        };
        if (_customer.WhetherLiveInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n==============\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n==============\n";
        shippingLabel += $"{_customer.GetName()} {_customer.GetAddress().GetAddressDetail()}";
        return shippingLabel;
    }

}