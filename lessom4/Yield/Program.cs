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
        static IEnumerable<int> func() //    פונקציה שמחזירה אוסף של מספרים
        {
            yield return 5;
            yield return 5;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 7 };
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = 5;
            }
            arr[0] = Math.Abs(-5);
        }
    }
}
