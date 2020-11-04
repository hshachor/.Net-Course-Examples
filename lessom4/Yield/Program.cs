using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    
    class Program
    {
        static IEnumerator<int> func() //    פונקציה שמחזירה אוסף של מספרים
        {
            yield return 25;
            yield return 36;
        }

        static void Main(string[] args)
        {
            //IEnumerable<int> coll = func();
            IEnumerator<int> iter = func();// coll.GetEnumerator();
            iter.MoveNext();
            Console.WriteLine(iter.Current);
            iter.MoveNext();
            Console.WriteLine(iter.Current);
            

        }
    }
}
