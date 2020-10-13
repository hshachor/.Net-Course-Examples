using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The main thread is : " + Thread.CurrentThread.ManagedThreadId);
            MultiThread();
        }

        //למדוד זמן התחלה וסוף ולהשוות לקודם.
        static void MultiThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Func1);
                t.Start();
                //איזה THREAD יודפס בשורה הבאה?
                Console.WriteLine("Current thread is?? " + Thread.CurrentThread.ManagedThreadId);
            }
        }

        static void OneThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Func1();
            }
        }
        static void Func1()
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


