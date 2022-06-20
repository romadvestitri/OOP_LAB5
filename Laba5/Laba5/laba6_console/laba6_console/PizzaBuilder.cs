using System;

namespace Pizzeria
{
    // builder
    abstract class Builder
    {
        public abstract void StartBuild(int size);
        public abstract void SetThinCrust();
        public abstract void AddCheese(int count, Cheese cheese);
        public abstract void AddVegetable(int count, Vegetable vegetable);
        public abstract void AddMeat(int count, Meat meat);
        public abstract object GetProduct();
    }
    
    class PizzaBuilder : Builder
    {
        private Pizza pizza;
        public override void StartBuild(int size)
        {
            pizza = new Pizza(size, false);
        }

        public override void SetThinCrust()
        {
            pizza.thinCrust = true;
        }
        public override void AddCheese(int count, Cheese cheese)
        {
            for (int i = 0; i < count; i++)
                pizza.Add(cheese);
        }
        public override void AddVegetable(int count, Vegetable vegetable)
        {
            for (int i = 0; i < count; i++)
                pizza.Add(vegetable);
        }
        public override void AddMeat(int count, Meat meat)
        {
            for (int i = 0; i < count; i++)
                pizza.Add(meat);
        }
        public override Pizza GetProduct()
        {
            return pizza;
        }
    }

    // director
    class PizzaPeperroniDirector
    {
        private Builder builder;
        public PizzaPeperroniDirector(PizzaBuilder pizzaBuilder)
        {
            builder = pizzaBuilder;
        }

        public object GetPizzaPeperroni(int size)
        {
            builder.StartBuild(size);

            builder.SetThinCrust();
            builder.AddCheese(2, new Parmesan());
            builder.AddVegetable(1, new Onion());
            builder.AddMeat(1, new Pepperoni());
            return builder.GetProduct();
        }
    }
}
