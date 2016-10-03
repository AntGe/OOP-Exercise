using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {
        private string subject;
        public Teacher(string Name, int Age) : base (Name,Age)
        {
            this.Subject = subject;
        }

        public string Subject { get; set; }
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
