using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid38
{
    class Program
    {
        public static void ex5()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums =
                from n in numbers
                select strings[n];
            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
                Console.WriteLine(s);
        }
        public static void ex6()
        {
            string[] strings = { "oshRi", "ezra", "eliEzer" };
            var v = from item in strings
                    select item.ToUpper();
            foreach (var s in v)
                Console.WriteLine(s);
        }
        public static void ex7()
        {
            string[] strings = { "oshRi", "ezra", "eliEzer" };
            var v = from item in strings
                    select new { Upper = item.ToUpper(), Lower = item.ToLower() };
            foreach (var s in v)
                Console.WriteLine("Uppercase: {0,-10}, Lowercase: {1}", s.Upper, s.Lower);
        }

        // nesting query //Output: 2,3,3,14,22,
        public static void ex12()
        {
            int[] numbersA = { 1, 2, 3, 4, 5, 14, 22 };
            int[] numbersB = { 22, 3, 12, 14, 3, 13, 2 };
            var result = from num in numbersA
                         from num2 in numbersB
                         where num == num2
                         select num;
            foreach (var item in result)
                Console.Write("{0}, ", item);
            Console.WriteLine();
        }

        //Distinct //Output: 2,3,14,22,
        public static void ex13()
        {
            int[] numbersA = { 1, 2, 3, 4, 5, 14, 22 };
            int[] numbersB = { 22, 3, 12, 14, 3, 13, 2 };
            var result = from num in numbersA
                         from num2 in numbersB
                         where num == num2
                         select num;
            foreach (var item in result.Distinct())
                Console.Write("{0}, ", item);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ex5(); ex6(); ex7();ex12();
            ex13();
        }
    }
}
