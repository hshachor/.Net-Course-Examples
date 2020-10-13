using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid36
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            object obj = x;
            Console.WriteLine(obj is object);
            Console.WriteLine(obj is string);
            Console.WriteLine(obj is ValueType);


        }

    }
}
