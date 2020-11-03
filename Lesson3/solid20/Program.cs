using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid20
{/// <summary>
/// הורשה של פונקציה וירטואלית עם העמסה
/// מקביל לדוגמא Ex5
/// </summary>
    class grandfather
    {
        public grandfather() 
        { 
            //Console.WriteLine($"new object say: {hello()}"); 
        }
        public virtual string hello()
        {
            return "i am grandfather";
        }
    }

    class father : grandfather
    {
        public override string hello()
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
            grandfather[] arr = new grandfather[3];
            arr[0] = new grandfather();
            arr[1] = new father();
            arr[2] = new son();

            for (int i = 0; i < 3; i++)
                Console.WriteLine(arr[i].hello());

            //------------
            ArrayList l = new ArrayList();
            l.Add(new grandfather());
            l.Add(new father());
            l.Add(new son());
            //l.Add(5);

            for (int i = 0; i < 3; i++)
                Console.WriteLine((l[i] as grandfather).hello());

            foreach (grandfather item in l)
            {
                Console.WriteLine((item as grandfather).hello());
            }

        }
    }
    class Student { }
    class Class : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
