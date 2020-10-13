using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// בנאי סטטי
/// מקביל לדוגמא Ex6
/// </summary>
namespace solid51
{
    class StaticConstructor
    {
        int y;
        static int x = 10;
        static StaticConstructor()
        {
            //y++;   בנאי סטטי לא יכול לקרוא לשדה לא סטטי
            System.Console.WriteLine("SampleClass static constructor called. x={0}", x++);
        }
        public StaticConstructor()
        {
            System.Console.WriteLine("SampleClass instance constructor called. x={0}", x++);
            System.Console.WriteLine("SampleClass instance constructor called. y={0}", y++);

        }
    }
    class MainClass
    {

        static void Main(string[] args)
        {
            StaticConstructor sc = new StaticConstructor();
            StaticConstructor sc2 = new StaticConstructor();
            StaticConstructor sc3 = new StaticConstructor();
        }


    }
}
