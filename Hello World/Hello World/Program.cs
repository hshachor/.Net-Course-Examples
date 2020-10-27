using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace Hello_World
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        public static int i;
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"> command line arguments</param>
        static void Main(string[] args)
        {
            string s = foo();
            Console.WriteLine("Hello " + s);
            System.Console.WriteLine(@"my string "" super
               And another line

           ");

        }

        /// <summary>
        /// This function ask user for his name.
        /// </summary>
        /// <returns>the name of the user</returns>
        private static string foo()
        {
            Console.WriteLine("Enter your name:");
            string s = Console.ReadLine();
            //Main(new string []{""});
            return s;
        }
    }
}
