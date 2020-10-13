using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };

            List<string> listString = list.ConvertAll<string>(f4);
            foreach (string item in listString)
            {
                Console.WriteLine(item);
            }
        }
        public static string f4(int x)
        {
            return "num is: " + x.ToString();
        }
    }
}
