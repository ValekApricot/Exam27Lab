using System;

public class Car
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void AddCar()
        {
            Console.WriteLine("Введите данные автомобиля:");

            Console.Write("Марка: ");
            Brand = Console.ReadLine();

            Console.Write("Модель: ");
            Model = Console.ReadLine();

            Console.Write("Год: ");
            int yearInput;
            while (!int.TryParse(Console.ReadLine(), out yearInput) || yearInput < 1900 || yearInput > DateTime.Now.Year)
            {
                Console.WriteLine("Неправильный формат года. Попробуйте еще раз.");
                Console.Write("Год: ");
            }
            Year = yearInput;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Марка: {Brand}\nМодель: {Model}\nГод: {Year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AddCar();
            Console.WriteLine("Введенные данные автомобиля:");
            car.DisplayCar();

            Console.ReadKey();
        }
    }

