using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Line3
    {
        private double length;   // Length of a line

        public Line3()
        {   // constructor
            Console.WriteLine("Object is being created");
        }
        ~Line3()
        {   //destructor
            Console.WriteLine("Object is being deleted");
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
