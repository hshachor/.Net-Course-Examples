using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid58c
{
    /// <summary>
    /// הדפסה של לוח הכפל מיושר לימין
    /// מקביל לדוגמא EX91
    /// </summary>
    public class Program
    {
        protected int a;
        static void Main(string[] args)
        {
            bool b = false;
            if (b == true)
            {
                Console.WriteLine("OK");
            }
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    Console.Write("{0 ,6:f} ", i * j);
                Console.WriteLine();
            }
            object o = new object();
            Program p = new Program();
            Console.WriteLine(o.GetType());
            Console.WriteLine(p.GetType());
            Program p1 = new Program();
            Console.WriteLine( p.ToString());
            if (p.Equals(p1) || object.Equals(p, p1)) { 
                Console.WriteLine("empty class are equals"); 
            }
            Program p2 = p1;
            Console.WriteLine(object.ReferenceEquals(p2, p1)); // true
            Console.WriteLine(object.ReferenceEquals(p, p1)); // false
            Console.WriteLine(p1);
            Console.WriteLine($"{ p2 == p1}, { p == p1}" );
            o = new int();
            Console.WriteLine(o);
            if (3.Equals(o)) { }
        }
    }
}
