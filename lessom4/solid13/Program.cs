using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex7
{
    public delegate bool conditionDelegate(int x);
    class Program
    {
        public static List<int> getNewList(List<int> list, conditionDelegate cond)
        {

            List<int> list2 = new List<int>();
            foreach (int item in list)
            {
                if (cond(item))
                    list2.Add(item);
            }
            return list2;
        }

        static bool condition(int x)
        {
            return x % 2 == 0;
        }
      
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 34, 56, 88, 33, 11 };

            conditionDelegate d = condition;

            List<int> newList = getNewList(list, d);
            list.FindAll(condition);

            foreach (int item in  newList) //list.FindAll(condition))
            {
                Console.WriteLine(item);
            }
        }
    }
}
