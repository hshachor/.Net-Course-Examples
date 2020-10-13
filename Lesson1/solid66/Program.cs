using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid66
{
    class Program
    {
        /// <summary>
        /// הדגמה לשימוש בשמות משתנה בפונקציה
        /// מקביל לדוגמא EX991
        /// </summary>
        /// <param name="name">שם</param>
        /// <param name="age">גיל</param>
        /// <param name="id">תז</param>
        public static void PrintPerson(string name, int age, int id)
        {
            Console.WriteLine
                ("id: {0} name: {1} age: {2}", id, name, age);
        }

        static void Main(string[] args)
        {
            PrintPerson(age: 29, name: "oshri", id: 1234);
        }
    }
}
