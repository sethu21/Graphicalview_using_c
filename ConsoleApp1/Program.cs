using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product Quantity");
            Console.WriteLine("3. Display All Products");
            Console.WriteLine("4. Calculate Total Inventory Value");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    UpdateQuantity(inventory);
                    break;
                case "3":
                    inventory.DisplayAllProducts();
                    break;
                case "4":
                    double totalValue = inventory.CalculateTotalValue();
                    Console.WriteLine("Total inventory value: $" + totalValue);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter product quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Product product = new Product(name, price, quantity);
        inventory.AddProduct(product);
    }

    static void UpdateQuantity(Inventory inventory)
    {
        Console.Write("Enter product name to update: ");
        string name = Console.ReadLine();

        Console.Write("Enter new quantity: ");
        int newQuantity = Convert.ToInt32(Console.ReadLine());

        inventory.UpdateProductQuantity(name, newQuantity);
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine("Product: " + Name + ", Price: $" + Price + ", Quantity: " + Quantity);
    }
}

class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    public void UpdateProductQuantity(string name, int newQuantity)
    {
        bool productFound = false;
        foreach (Product product in products)
        {
            if (product.Name == name)
            {
                product.Quantity += newQuantity;
                productFound = true;
                Console.WriteLine("Updated quantity for " + name + ".");
            }
        }
        if (!productFound)
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayAllProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
        }

        foreach (var product in products)
        {
            product.DisplayProduct();
        }
    }

    public double CalculateTotalValue()
    {
        double totalValue = 0.0;
        foreach (Product product in products)
        {
            totalValue += product.Price + product.Quantity;
        }
        return totalValue;
    }
}