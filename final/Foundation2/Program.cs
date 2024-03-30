using System;

class Program
{
    static void Main(string[] args)
    {
       Product product1 = new Product("Product 1", "P1", 10.00, 2);
        Product product2 = new Product("Product 2", "P2", 15.00, 3);
        Product product3 = new Product("Product 3", "P3", 20.00, 1);

        // Addresses
        Address address1 = new Address("333 Street St.", "town", "Oklahoma", "USA");
        Address address2 = new Address("123 main st", "city", "idaho", "USA");

        // Customers
        Customer customer1 = new Customer("Caroline Avance", address1);
        Customer customer2 = new Customer("Second Person", address2);

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\n-------------------------\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price: $" + order2.GetTotalPrice());
    } 
    }

