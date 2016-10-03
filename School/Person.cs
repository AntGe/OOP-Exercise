using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
    {
        private readonly string name;

        private int age;
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        
        public string Name { get;}
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello! My name is {0}", this.Name);
        }
    }
}
