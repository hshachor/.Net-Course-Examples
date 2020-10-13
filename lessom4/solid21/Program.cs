using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            var m2 = new { ID = 34, Name = "oshri" };
            var m3 = new { ID = 12, Name = "ron" };
            Console.WriteLine("m2 Type Name: " + m2.GetType().Name);
            Console.WriteLine("m3 Type Name: " + m3.GetType().Name);


            Console.WriteLine("m2 HashCode: 0x{0:X}", m2.GetHashCode());
            Console.WriteLine("m3 HashCode: 0x{0:X}", m3.GetHashCode());
            Console.WriteLine("m2.Equals(m3) == {0} ", m2.Equals(m3));

        }
    }
}
