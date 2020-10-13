using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74a
{
    interface IA
    {
        string GetString();
    }

    class B : IA
    {
        public virtual string f1()
        {
            return "B.f1()";
        }
        public virtual string GetString()
        {
            return "B.GetString() and " + f1();
        }
    }

    class C : B
    {
        public override string f1()
        {
            return "C.f1()";
        }
        public new string GetString()
        {
            return "C.GetString() and " + f1();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IA a = new C();
            B b = a as B;
            C c = a as C;
            Console.WriteLine(a.GetString());
            Console.WriteLine(b.GetString());
            Console.WriteLine(c.GetString());
        }
    }
}
