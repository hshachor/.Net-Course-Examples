using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
/// <summary>
/// מקביל לדוגמאEX8
/// מדגים את סדר האתחול
/// </summary>
namespace solid8
{
    class InitializationOrder
    {
        static void Main(string[] args)
        {
    //        BaseClass bc = new BaseClass();
            DerivedClass obj = new DerivedClass();
            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public Member m3 = new Member("instance member of BaseClass");
        static public Member m4 = new Member("static member of BaseClass");
        public BaseClass()
        {
            Console.Out.WriteLine("Hello from BaseClass instance constructor");
        }
        static BaseClass()
        {
            Console.Out.WriteLine("Hello from BaseClass static constructor");
        }
    }
    public class DerivedClass : BaseClass
    {
        public Member m2 = new Member("instance member of DerivedClass");
        static public Member m1 = new Member("static member of DerivedClass");
        public DerivedClass()
        {
            Console.Out.WriteLine("Hello from DerivedClass instance constructor");
        }
        static DerivedClass()
        {
            Console.Out.WriteLine("Hello from DerivedClass static constructor");
        }
    }
    public class Member
    {
        public Member(string who)
        {
            Console.Out.WriteLine(string.Format("Hello from a {0}", who));
        }
    }
}

