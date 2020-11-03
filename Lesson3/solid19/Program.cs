using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace solid19
{/// <summary>
/// בדוגמא זו רואים הסתרה כברירת מחדל בירושה
/// מקביל לדומא EX4
/// </summary>
    class grandfather
    {
        public string hello()
        {
            return "i am grandfather";
        }
    }

    class father : grandfather
    {
        public string hello()
        {
            return "i am father";
        }
    }
    class son : father
    {
        public string hello()
        {
            return "i am son";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            son s = new son();
            Console.WriteLine(s.hello()); // call Son.hello()
            //////////////////////////////////
            grandfather g = s;
            Console.WriteLine(g.hello()); // call Grandfather.hello()
            Console.WriteLine(g.GetType());
        }
    }
}
