using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
  abstract  class Vehicle
    {
       protected string color;
        public Vehicle()//parent default constructor invoke automatically for all child object
        {
            this.color = "white";
            Console.WriteLine("constructor from vehicle");
        }
        public Vehicle(string clr)//parent parameter constructor  has to be invoked using base keyword and providing value
        {
            this.color = clr;
            Console.WriteLine("parametrsized constructor");
        }
        public abstract void fill_fuel();//sholud compulsory override
        
        public virtual void start()//child may or maynot override
        {
            Console.WriteLine("started");
        }
        public void stop()
        {
            Console.WriteLine("stopped");
        }
    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus():base("red")
        {
            this.seating = 80;
            this.speed = 120;
            Console.WriteLine("constructor from bus");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("filled disel");
        }
        public void  Run()
        {
            Console.WriteLine(this.color + "Bus is running\t "+this.speed+"type \t"+this.seating+"passengers");
        }
        public override void start()
        {
            Console.WriteLine();
        }
    }
    class Car : Vehicle
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 160;
            this.type = "stanard";
            Console.WriteLine("constructor from car");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("filled disel");
        }
        public Car(string clr, int speed, string type) : base (clr)
            {
            this.speed = speed;
            this.type = type;
            }
        public void drive()
        {
            Console.WriteLine(this.color+"car is running at speed \t"+this.speed+"type \t"+this.type);
        }
    }
}
