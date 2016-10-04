using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Core
    {
        public Core(ICommandDispatcher Dispatcher)
        {
            this.Dispatcher = Dispatcher;
        }
        public void Run()
        {
            decimal a = 0;
            decimal b = 0;
            string input = "";
            while (input != "END")
            {
                try
                {
                    Console.WriteLine("Enter first number :");
                    a = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number :");
                    b = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("What do you want to do with them?");
                    Console.WriteLine("a - addition\ns - subtraction\nm - multiplication\nd - division");
                    input = Console.ReadLine();
                    ICommand command = null;
                    switch (input)
                    {
                        case "a":
                            command = this.Dispatcher.Commands.Where(c => c.Name == "addition").SingleOrDefault();
                            command.Act(a, b);
                            break;
                        case "s":
                            command = this.Dispatcher.Commands.Where(c => c.Name == "subtraction").SingleOrDefault();
                            command.Act(a, b);
                            break;
                        case "m":
                            command = this.Dispatcher.Commands.Where(c => c.Name == "multiplication").SingleOrDefault();
                            command.Act(a, b);
                            break;
                        case "d":
                            command = this.Dispatcher.Commands.Where(c => c.Name == "division").SingleOrDefault();
                            command.Act(a, b);
                            break;

                    }

                }
                catch (Exception)
                {                    
                }                
            }
        }
        public ICommandDispatcher Dispatcher { get; set; }
    }
}
