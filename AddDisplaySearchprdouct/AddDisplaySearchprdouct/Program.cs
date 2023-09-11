using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    static List<Product> products = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("E-commerce Store Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Search Products");
            Console.WriteLine("4. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    DisplayProducts();
                    break;
                case "3":
                    SearchProducts();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Product Price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Product Description: ");
        string description = Console.ReadLine();

        Product product = new Product
        {
            Name = $"Sujit_{name}_24124",
            Price = price,
            Description = description
        };

        products.Add(product);
        Console.WriteLine("Product added successfully!");
    }

    static void DisplayProducts()
    {
        Console.WriteLine("List of Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($" Price:{product.Price}");
            Console.WriteLine($"Description: {product.Description}");
            Console.WriteLine();
        }
    }

    static void SearchProducts()
    {
        Console.Write("Enter the product name to search: ");
        string searchName = Console.ReadLine();

        var foundProducts = products.Where(p => p.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundProducts.Any())
        {
            Console.WriteLine($"Found {foundProducts.Count} matching product(s):");
            foreach (var product in foundProducts)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price:C}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No matching products found.");
        }
    }
}




