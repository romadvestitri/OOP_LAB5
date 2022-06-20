using System;

namespace Pizzeria
{
    // command
    public interface ICommand
    {
        void Execute();
    }
    class CookCommand : ICommand
    {
        private Chef PizzaChef;
        private Order Order;
        public CookCommand(Chef chef, Order order)
        {
            PizzaChef = chef;
            Order = order;
        }
        
        public void Execute()
        {
            Console.WriteLine("Заказ передан повару");
            PizzaChef.GetOrder(Order);
            PizzaChef.Cook(Order);
        }
    }
    class СomplimentCommand: ICommand
    {
        private Chef PizzaChef;
        public СomplimentCommand(Chef chef)
        {
            PizzaChef = chef;
        }

        public void Execute()
        {
            PizzaChef.GetСompliment();
        }
    }
}
