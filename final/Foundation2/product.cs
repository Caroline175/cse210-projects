using System;
class Product
{
    public string Name { get; }
    public string Id { get; }
    public double PricePerUnit { get; }
    public int Quantity { get; }
    public double TotalCost { get { return PricePerUnit * Quantity; } }

    public Product(string name, string id, double pricePerUnit, int quantity)
    {
        Name = name;
        Id = id;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }
}
