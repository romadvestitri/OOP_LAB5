using System;
using System.Collections.Generic;

namespace Pizzeria
{
    class Pizza : OrderItemComposite
    {
        private const double MIN_SIZE = 21;
        private const int thinCrustPrice = 10;

        private int size;
        internal bool thinCrust;
        private List<Ingredient> Ingridients;
        public Pizza(int size, bool thinCrust)
        {
            this.size = size;
            this.thinCrust = thinCrust;
            Ingridients = new List<Ingredient>();
        }
        public override int GetPrice()
        {
            int price = 0;
            foreach (Ingredient ingridient in Ingridients)
            {
                price += ingridient.GetPrice();
            }
            if (thinCrust)
            {
                price += thinCrustPrice;
            }
            else
            {
                price += (int)(thinCrustPrice * 1.5);
            }
            price = (int)(price / (MIN_SIZE * MIN_SIZE) * (size * size));
            return price;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Пицца");
            Console.WriteLine("--------------------");
            Console.Write("  Тесто..........");
            if (thinCrust)
            {
                Console.WriteLine(thinCrustPrice);
            }
            else
            {
                Console.WriteLine((int)(thinCrustPrice * 1.5));
            }
            foreach (Ingredient ingredient in Ingridients)
            {
                ingredient.PrintInfo();
            }
            Console.WriteLine("--------------------");
            for (int i = 0; i < 17; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(GetPrice().ToString() + '\n');
        }
        public override void Add(IOrderItem orderItem)
        {
            Ingridients.Add((Ingredient)orderItem);
        }
    }
}
