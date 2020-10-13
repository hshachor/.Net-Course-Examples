using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{

    public delegate int someDelegate(int x, int y);

    class Program
    {
        static public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static public int mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            someDelegate myDelegate = new someDelegate(sum); // = sum; אפשר גם
            myDelegate += mult;

            foreach (someDelegate d in myDelegate.GetInvocationList())
                Console.WriteLine(d.Method);

            if (myDelegate is Delegate)
                Console.WriteLine("myDelegate is Delegate == true");

            //Console.WriteLine(myDelegate(1,1));
            //myDelegate.Invoke(1, 1);
            //זה מפעיל את כל הפונקציות שבדלגט, עם ובלי הפונקציה

            foreach (someDelegate item in myDelegate.GetInvocationList())
                Console.WriteLine(item.Invoke(1, 1));
            /// הלולאה נחוצה על מנת להדפיס
            /// -  ביצוע הפוקנציות נעשה בכל הפעלה של הדלגט,
            /// אבל להדפסה תופעל רק הפעולה האחרונה 

            
        }
    }
}
