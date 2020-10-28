using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Array
{
    class Program
    {
        static void printCollection(IEnumerable col)
        {
            Console.Write("{");
            
            for (IEnumerator iter = col.GetEnumerator(); iter.MoveNext();)
            {
                Console.Write($"{iter.Current}, ");
            }
            
            foreach (object item in col)
            {
                Console.Write($"{item}, ");
            }
            
            Console.WriteLine("}");
        }
        static void Main(string[] args)
        {/*
            int a;
            int.TryParse(Console.ReadLine(), out a);
            int[] arr;
            //int a = 10;
            arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            int[] arr2 = arr;
            arr2[5] = -1;
            Console.WriteLine(arr[5]);

            //System.Array arr3;
            //arr3.SetValue(6, 3);
           */
            ArrayList b = new ArrayList() { "a", 3, new Program(), "hello"};
            b.Add(new object());
            //b. = 20;
            b.Insert(1, 10);
            b[5] = 10;
            Console.WriteLine(b[3]);
            printCollection(b);

            List<int> l = new List<int>() { 1, 3, 5, 7 };
            l.Add(5);
            l.Insert(1, 2);
            printCollection(l);
            
        }
    }
}
