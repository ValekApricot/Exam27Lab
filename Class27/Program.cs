using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class27
{


    class Program
    {
        static void Main(string[] args)
        {
            DataEmploee dataemploee = new DataEmploee();
            dataemploee.AddEmploee();
            Console.WriteLine("Введенные персональные данные:");
            dataemploee.DisplayCar();

            Console.ReadKey();
        }
    }
}
