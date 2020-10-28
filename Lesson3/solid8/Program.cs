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
    class MyGenericClass<T, U> where T: new() where U:T, new()
    {
        T obj;
        void f()
        {
            obj = new T();
            obj = new U();// default(U);
        }
    }
    class InitializationOrder
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass obj = new DerivedClass();
            Console.ReadLine();
            DerivedClass obj2 = new DerivedClass();

            // Member m = new Member();//error
            MyGenericClass<int> genericClass = new MyGenericClass<int>();
            
        }
    }
    public class BaseClass
    {
        public Member m3 = new Member("instance member of BaseClass");
        static public Member m4 = new Member("static member of BaseClass");
        public BaseClass()
        {
            Console.Out.WriteLine("Hello from BaseClass instance constructor" +InitializationOrder.i++ );
        }
        static BaseClass()
        {
            Console.Out.WriteLine("Hello from BaseClass static constructor" +InitializationOrder.i++);
        }
    }
    public class DerivedClass : BaseClass
    {
        public Member m2 = new Member("instance member of DerivedClass");
        static public Member m1 = new Member("static member of DerivedClass");
        public DerivedClass()
        {
            Console.Out.WriteLine("Hello from DerivedClass instance constructor" + InitializationOrder.i++);
        }
        static DerivedClass()
        {
            Console.Out.WriteLine("Hello from DerivedClass static constructor" + InitializationOrder.i++);
        }
    }
    public class Member
    {
        public Member(string who)
        {
            Console.Out.WriteLine(string.Format("Hello from a {0}", who) + InitializationOrder.i++);
        }
    }
}

