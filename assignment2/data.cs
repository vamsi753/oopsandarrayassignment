using System;

class dataProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
}

class dataProgram
{
    static void Main()
    {
        dataProduct[] products = new dataProduct[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter details for Product {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price;

            while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Invalid price. Please enter a valid positive number for the price.");
                Console.Write("Price: ");
            }

            Console.Write("Description: ");
            string description = Console.ReadLine();

            products[i] = new dataProduct { Name = name, Price = price, Description = description };
        }

        Console.WriteLine("\nProduct Details:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Product {i + 1}:");
            Console.WriteLine($"Name: {products[i].Name}");
            Console.WriteLine($"Price: {products[i].Price}");
            Console.WriteLine($"Description: {products[i].Description}\n");
        }
    }
}
