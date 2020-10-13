using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid56
{
    public interface IPrint
    {
        void Print();
    }
    public interface IMath
    {
        int Sum();
        float Avg();
    }
    class Sample : IPrint, IMath
    {
        private byte num1;
        private byte num2;
        private byte num3;
        public Sample() { }             // constructor
        public Sample(byte n1, byte n2, byte n3)
        {   // constructor
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }
        public void Print()
        {
            Console.WriteLine("num1={0}, num2={1}, num3={2}", num1, num2, num3);
        }
        public int Sum()
        {
            return num1 + num2 + num3;
        }
        public float Avg()
        {
            return (float)Sum() / 3;
        }
    }
    class App
    {
        public static void Main()
        {
            Sample s = new Sample(1, 2, 4);
            s.Print();
            Console.WriteLine("sum = {0}, avg = {1}", s.Sum(), s.Avg());

            IPrint p = new Sample();
            p.Print();  //  חוקי
            p.Sum(); // טעות !!
            IMath m = new Sample();
            m.Sum();
        }
    }




}
