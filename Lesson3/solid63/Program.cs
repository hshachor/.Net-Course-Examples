using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid63
{
    public interface IPrint1
    {
        void Print();
    }
    public interface IPrint2
    {
        void Print();
    }
    class Sample : IPrint1, IPrint2
    {
        private int num;
        public Sample() { }
        public Sample(int num)
        {
            this.num = num;
        }
        void IPrint1.Print()
        {
            //מימוש מפורש  
            Console.WriteLine("num = " + num);
        }
        void IPrint2.Print()
        {
            // מימוש מפורש  
            Console.WriteLine("num = {0}", num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample(33);
            // s.Print();// טעות !! 
            ((IPrint1)s).Print();// קריאה למתודה מחייבת המרה  
            ((IPrint2)s).Print();
            IPrint1 i1 = new Sample(12);
            i1.Print();// פה רק מתודה אחת מוכרת  
            IPrint2 i2 = new Sample(45);
            i1.Print();
        }
    }
}
