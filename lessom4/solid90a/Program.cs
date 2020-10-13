using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// דוגמא לפונקציית הרחבה
/// </summary>
namespace solid90a
{
    class Tools
    {
        public static int ToInt1(string str)
        {
            return int.Parse(str);
        }
    }

    static class StaticTools
    {
        public static int ToInt2(this string str)
        {
            return int.Parse(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "434";

            int x = Tools.ToInt1(s);

            int y = s.ToInt2();
            Console.WriteLine("445".ToInt2());
        }
    }


}
