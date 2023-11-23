using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class24
{


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
    }

