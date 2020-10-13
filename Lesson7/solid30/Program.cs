using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid30
{
    class Program
    {
        static void ex2()
        {
           IEnumerable<int> arr1 =
                  new int[] { 1, 2, 3, 4, 5 }; IEnumerable<string> arr2 =
           arr1.Select(item => "number is " + item);
            foreach (var item in arr2)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            ex2();
        }
    }
}
