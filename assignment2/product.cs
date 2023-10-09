using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string UnitOfMeasurement { get; set; }
    public int Qty { get; set; }

    public Product(int productId, string productName, decimal price, string unitOfMeasurement, int qty)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        UnitOfMeasurement = unitOfMeasurement;
        Qty = qty;
    }
}

class productProgram
{
    static void Main()
    {
        Product product1 = new Product(1, "Widget", 9.99m, "Each", 100);

        Console.WriteLine("Product ID: " + product1.ProductId);
        Console.WriteLine("Product Name: " + product1.ProductName);
        Console.WriteLine("Price: $" + product1.Price);
        Console.WriteLine("Unit of Measurement: " + product1.UnitOfMeasurement);
        Console.WriteLine("Quantity: " + product1.Qty);
    }
}
