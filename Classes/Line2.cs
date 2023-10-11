using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
        class Line2
        {
            private double length;   // Length of a line

            public Line2(double len)
            {  //Parameterized constructor
                Console.WriteLine("Object is being created, length = {0}", len);
                length = len;
            }
            public void setLength(double len)
            {
                length = len;
            }
            public double getLength()
            {
                return length;
            }
        }
    
}
