using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };
            Predicate<int> p = f3;
            //             p += f4;
            List<int> list3 = list.FindAll(p);


            foreach (int item in list3)
            {
                Console.WriteLine(item);
            }
        }
        public static bool f3(int x)
        {
            return x % 3 == 0;
        }
        public static bool f4(int x)
        {
            return x % 2 == 0;
        }
    }
}
