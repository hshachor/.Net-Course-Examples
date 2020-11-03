using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid27
{/// <summary>
/// חפיפה של הפונקציהtostring
/// די מקביל לדוגמא Ex92
/// </summary>
    class A
    {
        private int x;
        private int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public 
            new 
            //override
            string ToString()
        {
            return "x = " + x + " y= " + y;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 8;
            Console.WriteLine(x.ToString());
            string str = "oshri";
            Console.WriteLine(str.ToString());
            */
            A a = new A(2, 4);
            Console.WriteLine(a); // object value = a; print value.ToString();
            Console.WriteLine(a.ToString()); // goto A.ToString()
        }
    }
}




// object value = a; write value.ToString()