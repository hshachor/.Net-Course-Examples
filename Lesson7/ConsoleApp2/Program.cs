using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void ex3()
        {
            IEnumerable<int> arr1 =
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> arr2 =
                arr1.Where(i => i % 2 == 0).Select(item => item * 2);
            foreach (var item in arr2)
                Console.WriteLine(item);
        }

        public static void ex3a()
        {
            IEnumerable<int> arr1 =
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> arr2 =
                     from item in arr1
                     where item % 2 == 0
                     select item * 2;

            foreach (var item in arr2)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            ex3();

            //ex3a();
        }
    }
}
