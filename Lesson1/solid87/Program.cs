﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace solid87
{
    /// <summary>
    /// דוגמא עם המחלקה נקודה ועם ref שמאפשר לעשות החלפה כמו שצריך
    /// בעצם זו החלפת מצביעים
    /// יש גם הסבר על הפונקציה tryparse שהזכרנו
    /// מקביל לדוגמא EX98
    /// </summary>
    class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string GetPointString()
        {
            return string.Format("({0},{1})", x, y);
        }
    }
    class Program
    {

        public static void Swap(ref Point p1, ref Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }
        public void f(out int i, bool flag)
        {
            if (flag)
            {
                i = 0;
            } else
            {
                i = 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {2}", 5, 4, 3);

            Point p_1 = new Point { X = 2, Y = 3 };

            Point p_2 = new Point { X = 4, Y = 5 };
            Swap(ref p_1, ref p_2);
            Console.WriteLine("p_1: " + p_1.GetPointString());
            Console.WriteLine("p_2: " + p_2.GetPointString());

            string str = "12334";
            int x;
            bool b = int.TryParse(str, out x);
            if (b)
            {
                Console.WriteLine(x);
            }
        }

    }
}
