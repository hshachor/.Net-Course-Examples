using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
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
