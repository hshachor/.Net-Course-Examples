using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid23
{
    /// <summary>
    /// עוד כל מיני משחקים עם וירטואליות - הסתרה והעמסה
    /// </summary>

    class grandfather
    {
        public virtual string hello()
        {
            return "i am grandfather";
        }
    }

    class father : grandfather
    {
        public new virtual string hello()
        {
            return "i am father";
        }
    }
    class son : father
    {
        public override string hello()
        {
            return "i am son";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            father a = new father();
            son b = new son();
            grandfather[] arr = new grandfather[3];
            arr[0] = new grandfather();
            arr[1] = a;
            arr[2] = b;
            father[] arr1 = new father[2];
            arr1[0] = a;
            arr1[1] = b;
            for (int i = 0; i < 3; i++)
                Console.WriteLine(arr[i].hello());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(arr1[i].hello());
            }
            Console.WriteLine(a.hello());
            Console.WriteLine(b.hello());
        }
    }
}
