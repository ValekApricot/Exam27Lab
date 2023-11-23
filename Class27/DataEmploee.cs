using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class27
{
    public class DataEmploee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronimic { get; set; }
        public string Phone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void AddEmploee() /*ввод персональных данных*/
        {
            Console.WriteLine("Введите ваши персональные данные:");

            Console.Write("Имя: ");
            LastName = Console.ReadLine();

            Console.Write("Фамилия: ");
            FirstName = Console.ReadLine();

            Console.Write("Отчество: ");
            Patronimic = Console.ReadLine();

            Console.Write("Номер телефона: ");
            Phone = Console.ReadLine();

            Console.Write("Марка автомобиля: ");
            Brand = Console.ReadLine();

            Console.Write("Модель машины: ");
            Model = Console.ReadLine();

            Console.Write("Год создания: ");
            int yearInput;
            while (!int.TryParse(Console.ReadLine(), out yearInput) || yearInput < 1900 || yearInput > DateTime.Now.Year) /*Проверка корректности формата вводимых данных*/
            {
                Console.WriteLine("Неправильный формат года. Попробуйте еще раз.");
                Console.Write("Год создания: ");
            }
            Year = yearInput;
        }

        public void DisplayCar() /*выводит введенные данные на экран*/
        {
            Console.WriteLine($"Имя: {LastName}\nФамилмя: {FirstName}\nОтчество: {Patronimic}\nНомер телефона: {Phone}\nМарка автомобиля: {Brand}\nМодель машины: {Model}\nГод создания: {Year}");
        }
    }
}
