using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex993
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 6;
            Console.WriteLine(d.GetType());
            d = "abc";
            Console.WriteLine(d.GetType());
            d = DateTime.Now;
            Console.WriteLine(d.GetType());

        }
    }
}
