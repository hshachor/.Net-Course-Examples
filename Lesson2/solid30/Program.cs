using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///הדגמה של משתנה סודר
///מקביל לדוגמאEX94 
/// </summary>
namespace solid30
{
    enum MyEnum { male, female }
    class A { public int a; }
    class Program
    {
        static void Main(string[] args)
        {
            MyEnum e1 = MyEnum.male;
            MyEnum e2 = e1;
            MyEnum e3 = MyEnum.female;
            Console.WriteLine("e1: " + e1);
            Console.WriteLine("e2: " + e2);
            Console.WriteLine("e3: " + e3);
            A a=new A();
            a.a = 3;
        }
    }

}
