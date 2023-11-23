using System;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }

    public void AddNewProduct(string name, string category, double price, int stockQuantity)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Имя не может быть пустым");
        }

        if (string.IsNullOrEmpty(category))
        {
            throw new ArgumentException("Категория не может быть пустой");
        }

        if (price <= 0)
        {
            throw new ArgumentException("Цена должна быть больше 0");
        }

        if (stockQuantity < 0)
        {
            throw new ArgumentException("Количество на складе не может быть отрицательным");
        }

        Name = name;
        Category = category;
        Price = price;
        StockQuantity = stockQuantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product();

        try
        {
            product.AddNewProduct("Ноутбук", "техника", 1500, 10);
            Console.WriteLine("Продукт успешно добавлен");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
