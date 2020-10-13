using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid45
{
    class Program
    {
        /// <summary>
        /// תכנית ראשית להדגמת המחלקה console
        /// </summary>
        /// <param name="args">למעשה, פרמטר מיותר ולא נחוץ</param>
        static void Main(string[] args)
        {
            Console.Beep(); //השמעת ביפ
            Console.WriteLine("!!!!!!!!!!"); //הדפסה
            Console.SetWindowSize(20, 20); // שינוי גודל מסך הפלט/קלט
            Console.Title = "FFFFFFFF"; // שינוי כותרת מסך קלט/פלט
            Console.BackgroundColor = ConsoleColor.Cyan; // שינוי צבע הרקע
            Console.ForegroundColor = ConsoleColor.DarkGreen; // שינוי צבע הכתב
            Console.WriteLine("hello"); //הדפסה
            Console.BackgroundColor = ConsoleColor.Blue; // שינוי צבע הרקע
            Console.ForegroundColor = ConsoleColor.Red; // שינוי צבע הכתב
        }
    }
}
