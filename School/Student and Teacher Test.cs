using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person stanka = new Person("Stanka", 69);
            stanka.Greet();
            Student gosho = new Student("Gosho", 5);
            gosho.Greet();
            gosho.ShowAge();
            gosho.Age = 20;
            gosho.ShowAge();
            Teacher teacher = new Teacher("Mr. Boring", 40);
            teacher.Greet();
            teacher.Explain();

        }
    }
}
