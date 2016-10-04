using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class BasicCommandDispatcher : ICommandDispatcher
    {
        public BasicCommandDispatcher()
        {
            this.Commands = new List<ICommand>() { new Addition(), new Subtraction(), new Multiplication(), new Division() };
        }
        public List<ICommand> Commands { get; set; }

        public void dispatchCommand(ICommand command,decimal firsrtNumber, decimal secondNumber)
        {
            command.Act(firsrtNumber, secondNumber);
        }
    }
}
