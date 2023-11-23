using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12KnishniyMagazinWindow.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){Title="Капитанская дочка",Description="Александр Сергеевич Пушкин", Cost=100},
            new OrderItem(){Title="Дубровский",Description="Александр Сергеевич Пушкин", Cost=200},
            new OrderItem(){Title="Сказка о царе Салтане",Description="Александр Сергеевич Пушкин", Cost=300}

        };
    }
}
 