using System;

public class Jewelry
{
    public string Name { get; set; }
    public string Material { get; set; }
    public double Price { get; set; }

    public void AddNewJewelry(string name, string material, double price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Имя не может быть пустым");
        }

        if (string.IsNullOrEmpty(material))
        {
            throw new ArgumentException("Материал не может быть пустым");
        }

        if (price <= 0)
        {
            throw new ArgumentException("Цена должна быть больше 0");
        }

        Name = name;
        Material = material;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jewelry jewelry = new Jewelry();

        try
        {
            jewelry.AddNewJewelry("Броня", "золотая", 1000);
            Console.WriteLine("Украшения добавлены успешно");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

