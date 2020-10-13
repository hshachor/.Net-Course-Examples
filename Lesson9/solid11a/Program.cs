using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid11a
{
    class Program
    {
        static void Main(string[] args)
        {
            // תהליכון יחיד
            OneThread();

        }
        //כדי לבדוק יעילות בהמשך - רשמו זמן התחלה וסוף של הרצה סינכרונית
        static void OneThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Func1();
            }
        }
        static void Func1()//את זה עשינו מקודם בתכנית הראשית - וכאן בפונקציה.
        {
            Console.WriteLine(DateTime.Now + " : Start " + Thread.CurrentThread.ManagedThreadId + " thread");
            for (int i = 0; i < 999999999; i++)
            {
                //do something
            }
            Console.WriteLine(DateTime.Now + " : Finish " + Thread.CurrentThread.ManagedThreadId + " thread");
        }
    }
}


