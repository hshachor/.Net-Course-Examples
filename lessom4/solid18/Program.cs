using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid18
{
    class Program
    {
        public static int add(int x, int y) { return x + y; }
        static private Func<int, int, int> getF()
        {
            int z = 1;
            Func<int, int, int> myDelegate = (x, y) => x + y + z;
            z = 2;
            return myDelegate;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = getF();
            Console.WriteLine(myDelegate(1, 1));
        }

    }
}
