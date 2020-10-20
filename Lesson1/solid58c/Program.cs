using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid58c
{
    /// <summary>
    /// הדפסה של לוח הכפל מיושר לימין
    /// מקביל לדוגמא EX91
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            if (b == true)
            {
                Console.WriteLine("OK");
            }
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    Console.Write("{0 ,6:f} ", i * j);
                Console.WriteLine();
            }

        }
    }
}
