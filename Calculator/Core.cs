using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Core
    {
        public Core()
        {

        }
        public void Run()
        {
            decimal a = 0;
            decimal b = 0;
            string input = "";
            while (input != "END")
            {
                Console.WriteLine("Enter first number :");
                a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number :");
                b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("What do you want to do with them?");
                Console.WriteLine("a - addition\ns - subtraction\nm - multiplication");
                input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        Console.WriteLine(Addition(a,b));
                        break;
                    case "s":
                        Console.WriteLine(Subtraction(a, b));
                        break;
                    case "m":
                        Console.WriteLine(Multiplication(a, b));
                        break;
                    case "d":
                        Console.WriteLine(Division(a, b));
                        break;

                }
            }
        }
        private decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }
        private decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }
        private decimal Multiplication(decimal a, decimal b)
        {
            return a * b;
        }
        private decimal Division(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
