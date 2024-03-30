using System;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.TotalCost;
        }
        // Adding shipping cost
        if (customer.Address.IsInUSA())
            totalPrice += 5;
        else
            totalPrice += 35;
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"Product: {product.Name}, ID: {product.Id}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName: {customer.Name}\nAddress:\n{customer.Address.GetAddressString()}";
    }
}
