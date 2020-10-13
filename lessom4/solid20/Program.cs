using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Ex8
{
    class MyClass
    {

        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void PrintInfo(Type type)
        {

            Console.WriteLine("Type Name: " + type.Name);
            Console.WriteLine("Base Type: " + type.BaseType);

            Console.WriteLine("MethodInfo:");
            MethodInfo[] info = type.GetMethods();
            foreach (var item in info)
                Console.WriteLine("name: {0,-15} Declaring in: {1} ",
    item.Name, item.DeclaringType.Name);
        }

        static void Main(string[] args)
        {
            var m1 = new MyClass();
            var m2 = new { ID = 34, Name = "oshri" };

            PrintInfo(m1.GetType());
            Console.WriteLine("-----------");
            PrintInfo(m2.GetType());
        }
    }


}
