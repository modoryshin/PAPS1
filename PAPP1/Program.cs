using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Установка кода клиента для первой фабрики + вызов объекта с помощью паттерна одиночки
            ClientCode obj1 = new ClientCode(DishFactory1.getInstance());
            //вызов метода объекта класса ItalianDish1 
            obj1.MakeIDish();
            //Установка кода клиента для второй фабрики + вызов объекта с помощью паттерна одиночки
            ClientCode obj2 = new ClientCode(DishFactory2.getInstance());
            //вызов метода объекта класса RussianDish2
            obj2.MakeRDish();
            Console.ReadKey();
        }
    }
}
