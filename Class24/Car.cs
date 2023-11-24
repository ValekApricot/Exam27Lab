using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class24
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void AddCar() /*ввод данных автомобиля*/ /*переменная*/
        {
            Console.WriteLine("Введите данные автомобиля:"); 

            Console.Write("Марка: ");
            Brand = Console.ReadLine();

            Console.Write("Модель: ");
            Model = Console.ReadLine();

            Console.Write("Год: ");
            int yearInput;
            while (!int.TryParse(Console.ReadLine(), out yearInput) || yearInput < 1900 || yearInput > DateTime.Now.Year) /*Проверка корректности формата вводимых данных*/
            {
                Console.WriteLine("Неправильный формат года. Попробуйте еще раз.");
                Console.Write("Год: ");
            }
            Year = yearInput;
        }

        public void DisplayCar() /*выводит введенные данные на экран*/
        {
            Console.WriteLine($"Марка: {Brand}\nМодель: {Model}\nГод: {Year}");
        }
    }
}
