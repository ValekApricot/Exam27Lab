using System;

public class Tour
{
    public string Destination { get; set; }
    public string Type { get; set; }
    public int Duration { get; set; }
    public decimal Price { get; set; }

    public void AddNewTour(string destination, string type, int duration, decimal price)
    {
        if (string.IsNullOrEmpty(destination))
        {
            throw new ArgumentException("Пункт назначения не может быть пустым");
        }

        if (string.IsNullOrEmpty(type))
        {
            throw new ArgumentException("Тип не может быть пустым");
        }

        if (duration <= 0)
        {
            throw new ArgumentException("Продолжительность должна быть больше 0");
        }

        if (price <= 0)
        {
            throw new ArgumentException("Цена должна быть больше 0");
        }

        Destination = destination;
        Type = type;
        Duration = duration;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tour tour = new Tour();

        try
        {
            tour.AddNewTour("Италия", "Лука", 5, 4000);
            Console.WriteLine("Тур успешно добавлен");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

