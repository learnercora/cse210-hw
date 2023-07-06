using System;

public class Product 
{
    private string _name;
    private string _productId;
    private double _price;
    private int _qty;
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }

    public Product(string name, string productId, double price, int qty)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _qty = qty;
    }

    public double CalculateTotalPrice()
    {
        double priceOfThisProduct = _price * _qty;
        return priceOfThisProduct;
    }

}