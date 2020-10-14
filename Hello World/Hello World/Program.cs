using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"></param>arguments from command line
        static void Main(string[] args)
        {
            askForName();
            System.Console.WriteLine(@"my string "" super
    And another line

");
        }

        private static void askForName()
        {
            Console.WriteLine("Enter your name:");
            string s = Console.ReadLine();
            Console.WriteLine("Hello " + s);
        }
    }
}
