using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid51
{
    class Program
    {
        public static void ex1()
        {
            var arr = new int[] { 2, 4, 5, 1, 5, 2, 3 };
            var v = (from item in arr
                     orderby item
                     where item % 2 == 0
                     select item);

            foreach (var item2 in v)
            {
                Console.WriteLine(item2);
            }
        }

        public static void ex2()
        {
            var arr = new int[] { 2, 4, 5, 1, 5, 2, 3 };
            var v = (from item in arr
                     where item % 2 == 0
                     orderby item
                     select item);

            foreach (var item2 in v)
            {
                Console.WriteLine(item2);
            }
        }


        static void Main(string[] args)
        {
            ex1();

            ex2();
        }
    }
}
