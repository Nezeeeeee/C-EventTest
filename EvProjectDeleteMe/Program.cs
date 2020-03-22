using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvProjectDeleteMe
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent myEvent = new MyEvent();
            Person Vasya = new Person(20, "Вася", "Чикист");
            if(Vasya.Name == "Вася")
            {
                myEvent.Boom += Vasya.ThisBoom;
                myEvent.CallBoom();
            }
            else ///if(Vasya.Name != "Вася")
            {
                myEvent.NoBoom += Vasya.ThisBoom;
                myEvent.CallNoBoom();
            }
            Console.Beep(1000, 2000);
            
            
        }
    }
}
