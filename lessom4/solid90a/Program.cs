using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A;
/// <summary>
/// דוגמא לפונקציית הרחבה
/// </summary>
namespace A
{
    static class StaticTools
    {
        public static int ToInt2(this string str)
        {
            return int.Parse(str);
        }
    }
    class Tools
    {
        public static int ToInt1(string str)
        {
            return int.Parse(str);
        }
    }

}

namespace solid90a
{
    

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
