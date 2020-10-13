using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid6
{
    class Program
    {
        static void Main(string[] args)
        {
            //מטרות
            //    1. הכרת המושג THREAD
            //    2. לכל THREAD יש מזהה
            //    3. גם ל MAIN THREAD יש ID
            //    4. אבחנה היכן אנו נמצאים כעת, מי מריץ את הקוד ברגע זה
            //    5. עבודה לא סיכרונית, לכן סדר הסיום לא בהכרח שווה לסדר ההתחלה
            //    6. חיסכון בזמן השוואה בין שני הפונקציות

            //    בהתחלה לשים את השורות הקשורות ל THREAD בהערה.
            //ניתן גם לנסות לכתוב לתוך הקונסול תוך כדי ריצה, זוהי פקודה ששיכת לת'רייד העיקרי - קלט /פלט 


            // One Thread
            //OneThread();

            //Multi Thread
            Console.WriteLine("The main thread is : " + Thread.CurrentThread.ManagedThreadId);
            MultiThread();

            //Console.ReadLine();
        }

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


