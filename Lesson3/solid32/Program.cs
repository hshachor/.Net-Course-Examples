using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid32
{/// <summary>
/// הדגמה של מחלקה אבסטרקטית
/// מקביל לדוגמא Ex93
/// </summary>
    public abstract class Shape
    {
        public abstract decimal GetArea();
    }

    public class Square : Shape
    {
        public int X;

        public override decimal GetArea()
        {
            return X * X;
        }
    }

    public class Rectangle : Shape
    {
        public int X;
        public int Y;

        public override decimal GetArea()
        {
            return X * Y;
        }
    }

    public class Circle : Shape
    {
        public int R;

        public override decimal GetArea()
        {
            decimal pi = (decimal)Math.PI;
            return pi * R * R;
        }
    }



    class Program
    {
        static decimal getTotalArea(params Shape[] shaps)
        {
            decimal sum = 0.0m;
            for (int i = 0; i < shaps.Length; i++)
                sum += shaps[i].GetArea();
            return sum;
        }
        static void Main(string[] args)
        {


            decimal d = getTotalArea
                (
                new Rectangle { X = 5, Y = 6 },
                new Circle { R = 2 },
                new Square { X = 2 });
            Console.WriteLine("total area: " + d);
        }
    }
}
