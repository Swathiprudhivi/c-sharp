using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate
{
    class Calculate
    {
        public static double CalArea(double r)
        {
            Console.WriteLine("calarea");
            return 3.14 * r * r;
        }
        public static double Caldistance(double d)
        {
            return d*100;
        }
    }
}
