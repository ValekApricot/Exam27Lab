using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17UridicheskaiFirmaWindow.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){FirstName="Вячислав",LastName="Матюхин", Patronimic= "Александрович",NumberPhone= "89257864356"},
            new OrderItem(){FirstName="Максим",LastName="Кириллин", Patronimic= "Сергеевич",NumberPhone= "89115329898"},
            new OrderItem(){FirstName="Андрей",LastName="Власов", Patronimic= "Семенович",NumberPhone= "84789214562"},
            new OrderItem(){FirstName="Павел",LastName="Лобутев", Patronimic= "Анатольевич",NumberPhone= "89778233243"}

        };
    }
}
