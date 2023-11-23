using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18SalonSotovoiSvaziWindow.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){Title="Безлимит от МТС",Description="Очень хорошая функция.", Cost=500},
            new OrderItem(){Title="SMS уведомления МТС",Description="Очень хорошая функция.", Cost=600},
            new OrderItem(){Title="Звонки в роуминге",Description="Очень хорошая функция.", Cost=800}

        };
    }
}
