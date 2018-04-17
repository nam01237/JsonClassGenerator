using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Person
    {
        public Person()
        {
            name = "nam";
            age = 20;
        }

        public string name;
        private int age;
            
    }

    class Man : Person
    { }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Man man = person as Man;

            Console.WriteLine(man.name);
        }
    }
}
