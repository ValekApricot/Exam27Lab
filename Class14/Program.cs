using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class14
{
    
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
}
