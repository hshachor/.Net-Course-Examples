using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid58b
{
    /// <summary>
    /// הדגמה של לוח הכפל מיושר לשמאל
    /// מקביל לדוגמא EX9
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                    Console.Write("{0 ,-3} ", i * j);

                Console.WriteLine();
            }

        }
    }
}
