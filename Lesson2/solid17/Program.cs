using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid17
{/// <summary>
/// דוגמא המראה שמחלקה היא הפניה בערימה, ולא מייצרת עצם חדש
/// רואים גם אתחול בערכי ברירת מחדל.
/// </summary>
    class Point
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1 = new Point();
            Console.WriteLine("p1 = {0}, {1}", p1.X, p1.Y);
            Point p2 = p1;
            p2.X = 3;
            Console.WriteLine("p1 = {0}, {1}", p1.X, p1.Y);
        }
    }

}
