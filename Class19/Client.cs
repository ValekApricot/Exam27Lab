using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class19
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void AddClient() /*ввод персональных данных*/
        {
            Console.WriteLine("Введите Данные Клиента:");

            Console.Write("ФИО: ");
            Name = Console.ReadLine();

            Console.Write("Адресс проживания: ");
            Address = Console.ReadLine();

            Console.Write("Номер телефона: ");
            PhoneNumber = Console.ReadLine();

            Console.Write("Почта: ");
            Email = Console.ReadLine();
        }

        public void DisplayClient() /*выводит введенные данные на экран*/
        {
            Console.WriteLine($"ФИО: {Name}\nАдресс: {Address}\nНомер телефона: {PhoneNumber}\nВаша почта: {Email}");
        }
    }
}
