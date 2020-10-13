using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex992
{
    class Program
    {
        public static dynamic Sum(params dynamic[] arg)
        {
            if (arg.Length == 0)
                return 0;

            dynamic sum = arg[0];
            foreach (var item in arg)
                sum += item;

            return sum;
        }

        static void Main(string[] args)
        {
            int intSum = Sum(2, 4, 1);
            dynamic numberSum = Sum(2, 4, 1, 2.5);
            dynamic stringSum = Sum("a", "bc", "d", 23, 3.4);

            dynamic d1 = new System.Dynamic.ExpandoObject();
            d1.Name = "";


            Console.WriteLine(intSum);
            Console.WriteLine(numberSum);
            Console.WriteLine(stringSum);
            Console.WriteLine(Sum());


        }
    }
}
