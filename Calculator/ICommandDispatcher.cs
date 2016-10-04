using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICommandDispatcher
    {
        List<ICommand> Commands { get; set; }
        void dispatchCommand(ICommand command, decimal firstNumber, decimal secondNumber);
    }
}
