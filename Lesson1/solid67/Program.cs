﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid82
{
    /// <summary>
    ///דוגמא של הבעיה בהשמה בלי איתחול 
    /// בדוגמא זו יש שימוש גם במאפיינים (מהמשך המצגת) והיא מופיע קצת שונה במצגת
    /// מקבילה לדוגמא EX97
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
        public static void Swap(Point p1, Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }

        static void Main(string[] args)
        {
            Point p_1 = new Point { X = 2, Y = 3 };
            Point p_2 = new Point { X = 4, Y = 5 };
            Swap(p_1, p_2);
            Console.WriteLine(p_1.GetPointString());
            Console.WriteLine(p_2.GetPointString());
        }

    }
}
