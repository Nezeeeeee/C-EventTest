using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvProjectDeleteMe
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public Person()
        {

        }

        public Person(int age, string name, string profession)
        {
            Age = age;
            Name = name;
            Profession = profession;
        }

        public void ThisBoom()
        {
            Console.WriteLine("Событие вызвано!");
            Console.WriteLine($"Возвраст:{Age}, Имя:{Name}, Профессия:{Profession}");
        }
    }
}
