using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid51a
{
    class Program
    {
        /// <summary>
        /// תכנית להדגמת השימוש ב@ במחרוזת להדפסה
        /// מקביל לדוגמא ex2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Object obj;
            
            Console.WriteLine(@"C:\Program Files\Microsoft Visual Studio 10.0");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("small number");
                    break;
                case 3:
                    Console.WriteLine("bye");
                    break;

            }
            Console.WriteLine(@" 
                            *
                          *   *
                         *******
                        ");

        }
    }
}
