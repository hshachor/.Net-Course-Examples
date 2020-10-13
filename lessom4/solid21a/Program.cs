using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex91
{
    class Program
    {
        static void Main(string[] args)
        {
            var m2 = new { ID = 34, Name = "oshri" };
            var m3 = new { ID = 34, Name = "oshri" };
            Console.WriteLine("m2 HashCode: 0x{0:X}", m2.GetHashCode());
            Console.WriteLine("m3 HashCode: 0x{0:X}", m3.GetHashCode());
            Console.WriteLine("m2.Equals(m3) == {0} ", m2.Equals(m3));


            var m4 = new { ID = 34, Name = "oshri" };
            var m5 = new { ID = 34, Name = "oshri" };
            Console.WriteLine("m4 HashCode: 0x{0:X}", m4.GetHashCode());
            Console.WriteLine("m5 HashCode: 0x{0:X}", m5.GetHashCode());
            Console.WriteLine("m4.Equals(m5) == {0} ", m4 == m5);


        }
    }
}
