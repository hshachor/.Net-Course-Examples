using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid35
{
    class Program
    {
        public static void ex8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace =
            numbers.Select((num, index) =>
                new { Num = num, InPlace = (num == index) });

            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);

        }

        static void Main(string[] args)
        {
            ex8();
        }
    }
}
