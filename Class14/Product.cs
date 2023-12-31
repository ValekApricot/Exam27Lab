﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class14
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void AddNewProduct(string name, string category, double price, int stockQuantity) /*переменная*/
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }

            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentException("Категория не может быть пустой");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Цена должна быть больше 0");
            }

            if (stockQuantity < 0)
            {
                throw new ArgumentException("Количество на складе не может быть отрицательным");
            }

            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }
}
