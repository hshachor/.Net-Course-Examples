using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        public static int i;
        static void Main(string[] args)
        {
            string s = foo();
            Console.WriteLine("Hello " + s);
            System.Console.WriteLine(@"my string "" super
               And another line

           ");

        }

        private static string foo()
        {
            Console.WriteLine("Enter your name:");
            string s = Console.ReadLine();
            return s;
        }
    }
}
