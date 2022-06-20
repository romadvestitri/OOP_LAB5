using System;
using System.Threading;

namespace Pizzeria
{
    class Chef
    {
        public void Cook(Order order)
        {
            Thread.Sleep(500);
            Console.WriteLine("Повар готовит");
            Thread.Sleep(500);
            Console.WriteLine("...готовит...");
            Thread.Sleep(500);
            Console.WriteLine($"Заказ номер {order.Number} готов!");
            Thread.Sleep(500);
        }
        public void GetOrder(Order order)
        {
            Console.WriteLine($"Повар принял заказ номер {order.Number}");
        }
        public void GetСompliment()
        {
            Console.WriteLine("Повар рад)");
        }
    }
}
