using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid28
{
    class Program
    {
        // where
        public static void ex1()
        {
            IEnumerable<int> arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Func<int, bool> func = myFunc;
            IEnumerable<int> v = arr.Where(func);

            foreach (var item in v)
                Console.WriteLine(item);
        }

        static bool myFunc(int x)
        {
            return x % 2 == 0;
        }

        public static void ex1_b()
        {
            IEnumerable<int> arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var v = arr.Where(t => t % 2 == 0);

            foreach (var item in v)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            ex1();
        }
    }
}
