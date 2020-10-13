using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid33a
{/// <summary>
/// דוגמא למנגנון החריגות בהקשר של קלט
/// מקביל לדוגמא Ex2
/// </summary>
    class Program
    {
        static int getAge()
        {
            try
            {
                Console.WriteLine("enter your age");
                string ageStr = Console.ReadLine();
                int age = int.Parse(ageStr);
                return age;
            }
            catch
            {
                Console.WriteLine("Please enter only numbers");
            }
            Console.WriteLine("after catch Block I'm still working");
            return 0;
        }

        static void Main(string[] args)
        {
            while (getAge() == 0) ;

        }

    }
}
