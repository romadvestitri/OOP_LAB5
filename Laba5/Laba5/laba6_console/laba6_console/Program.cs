using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Program
    {
        

        static void fwriteMD5(string text, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                
                Console.WriteLine("шифрование сохранено в файл");
            }
        }
        public static void Main()
        {
            Chef chef = new Chef();
            Waiter waiter = new Waiter();

            Order order = new Order();
            PizzaBuilder pizzaBuilder = new PizzaBuilder();


            pizzaBuilder.StartBuild(21);
            pizzaBuilder.AddCheese(1, new Mozzarella());
            pizzaBuilder.AddCheese(2, new Parmesan());
            pizzaBuilder.AddVegetable(2, new Tomato());
            pizzaBuilder.AddMeat(1, new Chicken());
            Pizza customPizza = pizzaBuilder.GetProduct();

            // add custom pizza to order
            order.Add(customPizza);
            // create and add pizza pepperroni
            PizzaPeperroniDirector peperroniDirector = new PizzaPeperroniDirector(pizzaBuilder);
            order.Add((Pizza)peperroniDirector.GetPizzaPeperroni(21));
            // add coffee to order
            order.Add(new Coffee(100));
            // print order info
            order.PrintInfo();

            // create new waiter command
            waiter.SetCommand(new CookCommand(chef, order));
            waiter.GoToChef();
            Console.WriteLine("\nВы сделали комплимент повару\n");
            waiter.SetCommand(new СomplimentCommand(chef));
            waiter.GoToChef();

            Console.ReadLine();
        } 

    }
}
