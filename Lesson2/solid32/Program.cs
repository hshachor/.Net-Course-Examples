using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid32
{/// <summary>
/// הדגמה של קלט מחרוזת והמרה שלו לשלם
/// מקביל לדוגמא Ex1
/// </summary>
    class Program
    {

        static int getAge()
        {
            Console.WriteLine("enter your age");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            return age;
            //Console.Read()
        }

        static void Main(string[] args)
        {
            while (getAge() == 0) ;
        }

    }
}
