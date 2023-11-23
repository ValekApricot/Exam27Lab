using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15
{
    

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
}
