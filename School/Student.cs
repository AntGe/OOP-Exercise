using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public Student(string Name, int Age) : base (Name,Age)
        {

        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to classes");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", this.Age);
        }        
    }
}
