using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid82
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStringVar = System.Console.ReadLine();
            //פקודה זו מחזירה מחרוזת
            int myCharUnicode = System.Console.Read();
            Console.WriteLine(myCharUnicode);
            //פקודה זו מחזירה את הערך בקוד יוניקוד של התו שנקלט
            Char myCharVar = (Char)System.Console.Read();
            Console.WriteLine(myCharVar);
            //פקודה זו מתרגמת את התו שנקלט לתו
        }
    }
}
