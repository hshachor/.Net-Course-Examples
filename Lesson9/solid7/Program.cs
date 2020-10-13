using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid11
{
    class Program
    {
        static void Main(string[] args)
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


