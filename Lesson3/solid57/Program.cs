using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid57
{

    interface IArea
    {
        double Area();
    }

    abstract class Shape
    {
        protected double x0, y0, x1, y1;
        public Shape(double x0, double y0, double x1, double y1)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
        }
        abstract public double MaxDistance();
    }

    class Circle : Shape, IArea
    {
        public Circle(double xcenter, double ycenter, double r) : base(xcenter - r, ycenter - r, xcenter + r, ycenter + r) { }
        override public double MaxDistance()
        {
            double dx = Math.Abs(x0 - x1);
            double dy = Math.Abs(y0 - y1);
            return Math.Max(dx, dy);
        }
        public double Area()
        {
            double r = Math.Abs((x0 - x1) / 2.0);
            return Math.PI * r * r;
        }
    }

    class Rectangle : Shape, IArea
    {
        public Rectangle(double x0, double y0, double x1, double y1) : base(x0, y0, x1, y1) { }
        override public double MaxDistance()
        {
            double dx = x0 - x1;
            double dy = y0 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double Area()
        {
            double dx = x0 - x1;
            double dy = y0 - y1;
            return Math.Abs(dx * dy);
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Rectangle(2, 2, 4, 4);
            shapes[1] = new Circle(1, 1, 2);

            double totalArea = 0.0;
            foreach (IArea shape in shapes)
            {
                totalArea += shape.Area();
            }
            Console.Out.WriteLine("Total area is {0}", totalArea);
        }
    }



}
