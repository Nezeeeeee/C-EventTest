using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvProjectDeleteMe
{

    public delegate void Action();
    class MyEvent
    {
        public event Action Boom;
        public event Action NoBoom;


        public void CallBoom()
        {
            Boom();
            Console.WriteLine("Вася взорван!");
        }

        public void CallNoBoom()
        {
            NoBoom();
            Console.WriteLine("Это не Вася!Пусть живет!");
        }
    }
}
