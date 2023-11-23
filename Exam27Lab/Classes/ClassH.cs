using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam27Lab.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){Title="Мячь Nike",description="Красивый и прыгучий", Cost= 4000},
            new OrderItem(){Title="Мячь Addidas",description="Красивый и прыгучий", Cost= 5000},
            new OrderItem(){Title = "Баскетбольный Мячь Nike", description = "Красивый и прыгучий", Cost = 7000},
            new OrderItem(){Title = "Баскетбольный Мячь Nike", description = "Красивый и прыгучий", Cost = 8000}

        };
    }
}