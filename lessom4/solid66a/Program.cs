using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
/// <summary>
/// Ex4 מקביל לדוגמא
/// </summary>
namespace solid66a
{
    //    הפונקציה PrintProperty<T>(T t)  (מוגדרת במקביל ל Main) מקבלת אובייקט מטיפוס T וחוקרת אותו
    //הפונקציה t.GetType() מחזירה את ה Type של האובייקט
    //ועליו מפעילים Ttype.GetProperties() שמחזירה מערך של איברים מטיפוס PropertyInfo
    //הטיפוס PropertyInfo מכיל פונקציות ומאפיינים כגון Name ו GetValue() שעוזרים לחקור שדות/מאפיינים של טיפוס כלשהו.

    class Program
    {
        public static void PrintProperty<T>(T t)
        {
            Type Ttype = t.GetType();
            PropertyInfo[] info = Ttype.GetProperties();
            foreach (PropertyInfo item in info)
            {
                Console.WriteLine
                    ("name: {0,-15} value: {1,-15}"
                    , item.Name, item.GetValue(t, null));
            }
        }


        static void Main(string[] args)
        {
            Person p = new Person
            {
                Id = 123,
                Married = true,
                PersonGender = Gender.male,
                PersonName = new Name { FirstName = "oshri", LastName = "Cohen" }
            };
            List<Person> list = new List<Person>();
            list.Add(p);
            Person p1 = list.Find(x => x.Id == 123);
            list.Remove(p1);

            PrintProperty(p1);
            Console.WriteLine();
            PrintProperty(DateTime.Now);
        }
    }
}
