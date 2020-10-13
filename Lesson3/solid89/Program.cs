using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid89
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
            return string.Format("[{0}], {1}]", xPos, yPos);
        }
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }

        class stud
        {

        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
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
                stud ben = new stud();
                stud bat = new stud();
                Swap<stud>(ref ben, ref bat);
                Swap(ref ben, ref bat);


            }
        }
    }
}
