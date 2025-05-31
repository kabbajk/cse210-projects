using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price:C}");
    }
}

class Order
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order Summary:");
        foreach (var product in Products)
        {
            product.DisplayInfo();
        }
        Console.WriteLine($"Total Cost: {GetTotalCost():C}");
    }
}

class Program
{
    static void Main()
    {
        // Creating products
        Product product1 = new Product("Laptop", 1200m);
        Product product2 = new Product("Mouse", 25m);
        Product product3 = new Product("Keyboard", 50m);

        // Creating order and adding products
        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        // Displaying order details
        order.DisplayOrder();
    }
}