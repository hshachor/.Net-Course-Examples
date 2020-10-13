﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid25
{
    /// <summary>
    /// תכנית זו מדגימה מבנה לעומת מחלקה - כאן ההעתקה היא עמוקה ולא רדודה
    /// מקביל לדוגמא EX93
    /// </summary>
    struct Point
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
            return "(" + x + "," + y + ")"; // return string.Format("({0},{1})", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 2;
            p1.Y = 3;

            Point p2 = p1;
            p2.Y = 6;
            Console.WriteLine("p1: " + p1.GetPointString());
            Console.WriteLine("p2: " + p2.GetPointString());

        }
    }
}
