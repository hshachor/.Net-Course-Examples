using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid36
{
    class Program
    {
        public static void ex9()
        {
            int[] numbers = { 1, 4, 1, 3, 9, 2, 5 };
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }

        public static void ex10()
        {
            string[] words = { "dot net", "oshri", "java" };
            int sum = words.Sum(item => item.Length);

            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            ex9();
            ex10();
        }
    }
}
