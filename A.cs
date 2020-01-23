using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demopolimorphism
{
   abstract class A
    {
        //public  virtual void display()
        //{
        //    Console.WriteLine("dispaly A class details");
        //}
        public abstract void display();
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B class details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display C class details");
        }
    }
}
