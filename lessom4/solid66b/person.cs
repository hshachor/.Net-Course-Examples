using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid66b
{
    //    שימו לב!
    //דרסנו את ToString במחלקה Name וגם במחלקה Person.
    //וקראנו משם ל
    //ToStringProperty
    //שהיא פונקציה של המחלקה ToolStringClass.
    //ולכן - הוא מדפיס את הפרטים יפה גם עבור המחלקה הפנימית

    public interface IKey
    {
        int Key { get; }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return ToolStringClass.ToStringProperty(this);
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
        public override string ToString()
        {
            return ToolStringClass.ToStringProperty(this);
        }

    }
}
