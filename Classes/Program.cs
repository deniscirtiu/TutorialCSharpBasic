using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Classes
{
    class BoxWithConstructor
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }

    class Box
        {
            public double length;   // Length of a box
            public double breadth;  // Breadth of a box
            public double height;   // Height of a box
        }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // box 2 specification
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            // volume of box 1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2 : {0}", volume);

            //Constructors
            BoxWithConstructor Box3 = new BoxWithConstructor();   // Declare Box1 of type Box
            BoxWithConstructor Box4 = new BoxWithConstructor();
            double volume2;

            // Declare Box3 of type Box
            // box 3 specification
            Box3.setLength(6.0);
            Box3.setBreadth(7.0);
            Box3.setHeight(5.0);

            // box 4 specification
            Box4.setLength(12.0);
            Box4.setBreadth(13.0);
            Box4.setHeight(10.0);

            // volume of box 1
            volume2 = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume2);

            // volume of box 2
            volume2 = Box4.getVolume();
            Console.WriteLine("Volume of Box4 : {0}", volume2);

            //LINE class call from another file

            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Line2 line2 = new Line2(10.0);
            Console.WriteLine("Length of line : {0}", line2.getLength());

            // set line length
            line2.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line2.getLength());

            //Line 3 with destructor
            Console.WriteLine("Line3 with destructor");
            Line3 line3 = new Line3();

            // set line length
            line3.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line3.getLength());
            

            //STATIC VAR 
            Console.WriteLine("Static variable /n/n/n");
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.count();
            s1.count();
            s1.count();

            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());

            //Thread.Sleep(5000);
            Console.ReadKey();
        }
    }
    }
