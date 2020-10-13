using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid51b
{
    class Program
    {
        /// <summary>
        /// תכנית להדגמת השימוש בסימן + , גם בהדפסה
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
            userName = "GoodBye " + userName;
            Console.WriteLine(userName);
        }
    }
}
