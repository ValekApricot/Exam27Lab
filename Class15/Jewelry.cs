using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class15
{
    public class Jewelry
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }

        public void AddNewJewelry(string name, string material, double price) /*переменная*/
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }

            if (string.IsNullOrEmpty(material))
            {
                throw new ArgumentException("Материал не может быть пустым");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Цена должна быть больше 0");
            }

            Name = name;
            Material = material;
            Price = price;
        }
    }
}
