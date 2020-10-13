using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid106
{
    /// <summary>
    /// דוגמא נוספת למאפיין הפעם עם משמעות למצב
    /// מקביל לדוגמא EX96
    /// </summary>
    class MyClass
    {
        private int m_x;
        public int X
        {
            get
            {
                if (m_x < 0)
                    return 0;
                else
                    return m_x;
            }
            set
            {
                if (value != 99)
                    m_x = value;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.X = 8;
            Console.WriteLine(myClass.X);
        }
    }
}
