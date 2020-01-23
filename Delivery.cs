using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeliverydetails
{
    class Delivery
    {
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("bowler name is:" + bowler);
            Console.WriteLine("batsman name is:" + batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
                Console.WriteLine("IT IS A SIX");
            else if(runs==4)
            
                Console.WriteLine("IT IS A FOUR");
            else
            Console.WriteLine("run details:" + runs);
           
        }
    }
}
