using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Multiplication : ICommand
    {
        public Multiplication()
        {
            this.Name = "multiplication";
        }

        public string Name { get; }

        public void Act(decimal firstNumber, decimal secondNumber)
        {
            Console.WriteLine("{0} * {1} = {2}", firstNumber.ToString(), secondNumber.ToString(), (firstNumber * secondNumber).ToString());
        }
    }
}
