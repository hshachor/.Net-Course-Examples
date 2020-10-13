using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid57a
{
    /// <summary>
    /// הדגמה של הדפסה בפורמט
    /// מקביל לדוגמאEX6
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;
            Console.WriteLine("{0:f} + {1:e} = 0x{2:X} ", x, y, x + y);
        }
    }
}
