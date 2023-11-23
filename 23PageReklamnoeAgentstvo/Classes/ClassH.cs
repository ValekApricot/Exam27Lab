using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23PageReklamnoeAgentstvo.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){Title="МОЛОКО",description="В БОЛЬШО ГОРОДЕ", Cost= 4000},
            new OrderItem(){Title="ПЯТЕРОЧКА",description="Я ЗНАЮ ЦЕНЫ В ПЯТЕРОЧКЕ", Cost= 5000},
            new OrderItem(){Title = "Coast", description = "Морепродукты", Cost = 7000},
            new OrderItem(){Title = "Природа", description = "это не переварит", Cost = 8000}

        };
    }
}

