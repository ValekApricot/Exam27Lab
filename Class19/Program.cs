using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class19
{
        class Program
        {
            static void Main(string[] args)
            {
                Client client = new Client();
                client.AddClient();
                Console.WriteLine("Введенные данные о Клиенте:");
                client.DisplayClient();

                Console.ReadKey();
            }
        }
    }

