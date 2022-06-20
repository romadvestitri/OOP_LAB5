using System;

namespace Pizzeria
{
    class Waiter
    {
        private ICommand Command;

        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        
        public void GoToChef()
        {
            Console.WriteLine("Официант ушел на кухню");
            Command.Execute();
            Console.WriteLine("Официант вернулся с кухни");
        }
    }
}
