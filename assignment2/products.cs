using System;

class productsProgram
{
    static void Main()
    {
        Product product1 = new Product(1, "Widget", 9.99m, "Each", 100);
        Product product2 = new Product(2, "Gadget", 19.95m, "Each", 50);
        Product product3 = new Product(3, "Tool", 29.99m, "Each", 75);
        Product product4 = new Product(4, "Appliance", 199.99m, "Each", 10);
        Product product5 = new Product(5, "Accessory", 4.99m, "Each", 200);

        Console.WriteLine("\nProduct 1:");
        DisplayProductInfo(product1);

        Console.WriteLine("\nProduct 2:");
        DisplayProductInfo(product2);

        Console.WriteLine("\nProduct 3:");
        DisplayProductInfo(product3);

        Console.WriteLine("\nProduct 4:");
        DisplayProductInfo(product4);

        Console.WriteLine("\nProduct 5:");
        DisplayProductInfo(product5);
    }

    static void DisplayProductInfo(Product product)
    {
        Console.WriteLine("Product ID: " + product.ProductId);
        Console.WriteLine("Product Name: " + product.ProductName);
        Console.WriteLine("Price: $" + product.Price);
        Console.WriteLine("Unit of Measurement: " + product.UnitOfMeasurement);
        Console.WriteLine("Quantity: " + product.Qty);
    }
}
