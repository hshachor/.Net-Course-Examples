using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// מקביל לדוגמא Ex1
/// מה שרואים בתכנית הזו הוא שימוש במחלקת רשימה הגנרית.
/// יש לה פעולות משלה להוספה והורדה וכו'.
/// המחלקה שנבנית כאן אכן לא מחדשת דבר, אבל זו דוגמא טובה איך בונים מחלקה משלנו על בסיס מחלקה קיימת
/// היה אפשר גם להגדיר כאן אינדקסר.
/// </summary>
namespace solid9
{
    public class MyList<T>
    {
        List<T> list;
        public MyList()
        {
            list = new List<T>();
        }
        public bool Add(T t)
        {
            list.Add(t);
            return true;
        }
        public bool remove(T t)
        {
            return list.Remove(t);
        }

        public override string ToString()
        {
            string str = "[";
            for (int i = 0; i < list.Count; i++)
            {
                str += list[i] + "] -> [";
            }
            return str.Substring(0, str.Length - 1);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 4; i++)
                list.Add(i);
            Console.WriteLine(list);

        }
    }
}
