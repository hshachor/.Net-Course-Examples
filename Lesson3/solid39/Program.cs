using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid39
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            Console.WriteLine("x is valueType " + x is ValueType);
            Console.WriteLine("x is valueType {0}", x is ValueType);

        }
    }
}
