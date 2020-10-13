using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid6
{
    //הגדרת רשומה(מבנה)
    public struct Point<T>
    {
        private T xPos;

        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        private T yPos;

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }


        static public void Swap<U>(ref U a, ref U b)
        {
            U temp;
            temp = a;
            a = b;
            b = temp;
        }
    }

    class stud
    {
        public string name { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return string.Format("name: {0}, id: {1}",name,id);
        }
    }

    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            stud ben = new stud(){name = "Avraham", id =123};
            stud bat = new stud(){ name = "Shara", id = 456 };
            Console.WriteLine("begin : ben - {1} , bat - {2} ", 0, ben, bat);

            int num = 1;
            Swap<stud>(ref ben, ref bat);
            Console.WriteLine("swap num {0} : ben - {1} , bat - {2} ", num, ben, bat);
            num++;
            Swap(ref ben, ref bat);
            Console.WriteLine("swap num {0} : ben - {1} , bat - {2} ", num, ben, bat);
            num++;
            Point<int>.Swap<stud>(ref ben, ref bat);
            Console.WriteLine("swap num {0} : ben - {1} , bat - {2} ", num, ben, bat);

            Console.WriteLine();

            Point<stud> p = new Point<stud>(new stud() { name = "Avraham", id = 123 }, new stud() { name = "Shara", id = 456 });
            Console.WriteLine("begin : X - {0} , Y - {1} ", p.X, p.Y);
            Console.WriteLine("print: {0}", p);
            p.ResetPoint();
          
            Console.WriteLine("reset : X - {0} , Y - {1} ", p.X, p.Y);



        }
    }
}


