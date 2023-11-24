using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9
{
    public class Tour
    {
        public string Destination { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }

        public void AddNewTour(string destination, string type, int duration, decimal price) /*переменная*/
        {
            if (string.IsNullOrEmpty(destination))
            {
                throw new ArgumentException("Пункт назначения не может быть пустым");
            }

            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentException("Тип не может быть пустым");
            }

            if (duration <= 0)
            {
                throw new ArgumentException("Продолжительность должна быть больше 0");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Цена должна быть больше 0");
            }

            Destination = destination;
            Type = type;
            Duration = duration;
            Price = price;
        }
    }

}
