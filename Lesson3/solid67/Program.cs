using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6
{
    class Program
    {

        public static void Remove<T>(List<T> list, T t) where T : IComparable
        {
            T temp = default(T);
            foreach (T item in list)
            {
                if (t.CompareTo(item) == 0)
                {
                    temp = item;
                    break;
                }
            }

            if (temp != null)
                list.Remove(temp);
        }

        public static void Update<T>(List<T> list, T t) where T : IComparable
        {
            T temp = default(T);
            int index = 0;
            foreach (T item in list)
            {
                if (t.CompareTo(item) == 0)
                {
                    temp = item;
                    break;
                }
                index++;
            }

            if (temp != null && index < list.Count)
                list[index] = t;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5 };

            Remove(list, 3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}





