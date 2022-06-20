using System;

namespace Pizzeria
{
    abstract class Drink : OrderItem
    {
        protected int Volume;
        public int DefaultVolume = 100;
        protected int Price;
        public string Name;
        public override int GetPrice()
        {
            return Price;
        }
        public override void PrintInfo()
        {
            Console.Write(Name);
            for (int i = 0; i < 17 - Name.Length; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine(Price);
        }
    }

    class Coffee : Drink
    {
        public static int DefaultPrice = 10;
        public Coffee(int volume)
        {
            Name = "Кофе";
            Volume = volume;
            Price = (int)((double)volume / DefaultVolume) * DefaultPrice;
        }
    }
    class Tea : Drink
    {
        public static int DefaultPrice = 6;
        public Tea(int volume)
        {
            Name = "Чай";
            Volume = volume;
            Price = (int)((double)volume / DefaultVolume) * DefaultPrice;
        }
    }
    class Cola : Drink
    {
        public static int DefaultPrice = 8;
        public Cola(int volume)
        {
            Name = "Кола";
            Volume = volume;
            Price = (int)((double)volume / DefaultVolume) * DefaultPrice;
        }
    }
}
