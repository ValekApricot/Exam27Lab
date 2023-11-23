using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9
{
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
}
