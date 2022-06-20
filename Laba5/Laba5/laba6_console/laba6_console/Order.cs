using System;
using System.Collections.Generic;

namespace Pizzeria
{
    // composite
    public interface IOrderItem
    {
        public abstract int GetPrice();
        public abstract void PrintInfo();
    }
    public abstract class OrderItem : IOrderItem
    {
        public abstract int GetPrice();
        public abstract void PrintInfo();
    }
    public abstract class OrderItemComposite : IOrderItem
    {
        public abstract int GetPrice();
        public abstract void PrintInfo();
        public abstract void Add(IOrderItem item);
    }

    class Order : OrderItemComposite
    {
        public int Number;
        private static int count = 0;
        private List<IOrderItem> OrderList = new List<IOrderItem>();

        public Order()
        {
            count++;
            Number = count;
        }

        public override void Add(IOrderItem orderItem)
        {
            OrderList.Add(orderItem);
        }
        public override int GetPrice()
        {
            int price = 0;
            foreach (IOrderItem orderItem in OrderList)
            {
                price += orderItem.GetPrice();
            }
            return price;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Номер заказа: " + Number.ToString() + '\n');
            foreach (IOrderItem orderItem in OrderList)
            {
                orderItem.PrintInfo();
            }
            Console.WriteLine("\nИтого:           " + GetPrice().ToString());
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}