using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
/// <summary>
/// מקביל לדוגמא Ex99
/// דוגמא לביצוע רפלקציה בפונקציית הרחבה
/// </summary>
namespace solid90b
{
    static class StaticClass
    {
        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            foreach (PropertyInfo item in t.GetType().GetProperties())
                str += "\n" + item.Name + ": " + item.GetValue(t, null);
            return str;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>
    {
    new Person
    {
        Id = 1234,
        Married = true,
        PersonGender = Gender.female,
        PersonName = new Name { FirstName = "oshri", LastName = "c" }
    },
    new Person
    {
        Id = 5678,
        Married = false,
        PersonGender = Gender.female,
        PersonName = new Name { FirstName = "ss", LastName = "tt" }
    }
    };

            foreach (var item in personList)
            {
                Console.WriteLine(item);
            }
        }


    }
}
