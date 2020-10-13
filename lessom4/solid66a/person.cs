using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid66a
{
    //    שימו לב!
    //דרסנו את ToString במחלקה Name.
    //ולא דרסנו במחלקה Person

    public interface IKey
    {
        int Key { get; }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// דריסה זו נדרשת על מנת שידפיס את השם נכון.
        /// כאן לא נכנס לתתי המחלקות שם פרטי ומשפחה!
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "hfjhghj";
        }
    }

    public enum Gender { male, female }

    public class Person : IKey
    {
        public int Id { get; set; }
        public Name PersonName { get; set; }
        public Gender PersonGender { get; set; }
        public bool Married { get; set; }

        public int Key
        {
            get
            {
                return Id;
            }
        }
    }
}
