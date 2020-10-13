using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid92
{/// <summary>
/// דוגמא לחפיפת אופרטור להמרה מרומזת ומפורשת
/// </summary>
    class Vector
    {
        private double x, y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static explicit operator Vector(double d)
        {
            return new Vector(d, d);
        }
        public static implicit operator double(Vector v)
        {
            return Math.Sqrt(v.x * v.x + v.y * v.y);
        }
        public override string ToString()
        {
            return String.Format("[{0},{1}]", x, y);
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 2.2;
            Vector v1 = new Vector(1, 1);
            double d2 = v1;
            System.Console.WriteLine(d2);
            Vector v2 = (Vector)d2;
            System.Console.WriteLine(v2);// will print it like a double. why?
            //answer: because this type is more simple. and he prefers to print it simpler.
            //question: how can we print it like a vector? 
            //call v.ToString()
            System.Console.WriteLine(v2.ToString());
        }
    }


}
