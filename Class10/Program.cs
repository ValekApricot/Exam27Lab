using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            try
            {
                book.AddNewBook("1836", "Сергеевич Пушкин", "Капитанская дочка", 1000);
                Console.WriteLine("Книга успешно добавлена");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
