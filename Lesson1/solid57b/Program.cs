using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid57b
{
    /// <summary>
    /// הדגמה להדפסה בפורמט
    /// מקביל לדוגמא EX7
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100000;
            Console.WriteLine("{0} ", x);
            Console.WriteLine("{0:n} ", x);
        }
    }
}
