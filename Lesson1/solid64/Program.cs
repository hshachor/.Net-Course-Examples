using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid64
{
    /// <summary>
    /// הדגמה לשימוש במערך של פרמטרים בפונקציה
    /// מקביל לדוגמא EX99
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4));
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(6));
            Console.WriteLine(Sum(10, 5));
            Console.WriteLine(Sum(13, 2, 26, 14, 5, 6, 7, 8, 9, 19, 11, 34, 67, 89, 123, 56));
        }

        /// <summary>
        /// פונקציה עם מערך פרמטרים.
        /// שימו לב שניתן להשתמש בפונקציה עוד לפני ההצהרה עליה
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
