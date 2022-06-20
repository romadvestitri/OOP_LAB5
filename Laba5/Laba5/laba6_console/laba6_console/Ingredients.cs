using System;

namespace Pizzeria
{
    public static class Prices
    {
        internal const int Mozzarella = 5;
        internal const int Parmesan = 10;

        internal const int Tomato = 7;
        internal const int Mushrooms = 12;
        internal const int Onion = 8;
        internal const int Olives = 4;

        internal const int Pepperoni = 15;
        internal const int Becon = 16;
        internal const int Chicken = 17;
    }

    abstract class Ingredient : OrderItem
    {
        public int Price;
        public string Name;
        public override int GetPrice()
        {
            return Price;
        }
        public override void PrintInfo()
        {
            Console.Write("  " + Name);
            for (int i = 0; i < 15 - Name.Length; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine(Price);
        }
    }

    abstract class Cheese : Ingredient { }

    class Mozzarella : Cheese
    {
        public Mozzarella()
        {
            Name = "Моцарелла";
            Price = Prices.Mozzarella;
        }
    }
    class Parmesan : Cheese
    {
        public Parmesan()
        {
            Name = "Пармезан";
            Price = Prices.Parmesan;
        }
    }

    abstract class Vegetable : Ingredient { }

    class Tomato : Vegetable
    {
        public Tomato()
        {
            Name = "Помидоры";
            Price = Prices.Tomato;
        }
    }
    class Mushrooms : Vegetable
    {
        public Mushrooms()
        {
            Name = "Грибы";
            Price = Prices.Mushrooms;
        }
    }
    class Onion : Vegetable
    {
        public Onion()
        {
            Name = "Лук";
            Price = Prices.Onion;
        }
    }
    class Olives : Vegetable
    {
        public Olives()
        {
            Name = "Оливки";
            Price = Prices.Olives;
        }
    }

    abstract class Meat : Ingredient { }

    class Pepperoni : Meat
    {
        public Pepperoni()
        {
            Name = "Пепперони";
            Price = Prices.Pepperoni;
        }
    }
    class Becon : Meat
    {
        public Becon()
        {
            Name = "Бекон";
            Price = Prices.Becon;
        }
    }
    class Chicken : Meat
    {
        public Chicken()
        {
            Name = "Курица";
            Price = Prices.Chicken;
        }
    }
}
