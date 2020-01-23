using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demopolimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape pic = new Shape();
            //pic.draw();
            //pic.draw(10);
            //pic.draw(10, 20);
            //pic.draw(10, 25, 12);
            //pic.draw(1, 1, 1, "cube");
            //Console.ReadLine();
            //A obj = new A();
            //obj.display();
            //B obj1 = new B();
            //obj1.display();
            //C obj2 = new C();
            //obj2.display();
            //Console.ReadLine();


            A obj;
            obj = new B();
            obj.display();
            C obj2 = new C();
            obj2.display();
            Console.ReadLine();
        }
    }
}
