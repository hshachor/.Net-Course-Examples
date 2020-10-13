using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid68
{
    class Student : IComparable
    {
        double id;
        string name;

        public Student(double p_id, string p_name)
        {
            this.id = p_id;
            this.name = p_name;
        }
        public override string ToString()
        { return "id is: " + id + " name is: " + name; }

        public int CompareTo(object obj)// (Student other)
        {
            Student s = (Student)obj;

            //sort by id, using CompareTo of the int type
            //return id.CompareTo(s.id); // (other.id)

            //sort by name, using CompareTo of the string 
            //return name.CompareTo(s.name); 

            if (id > s.id)
                return 1;
            if (id < s.id)
                return -1;
            return 0;


        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Student> stu = new List<Student>();
                stu.Add(new Student(111111112, "name3"));
                stu.Add(new Student(111111111, "name5"));
                stu.Add(new Student(111111113, "name1"));

                IComparable s1 = new Student(22, "aaa");
                IComparable s2 = new Student(11, "bbb");
                Console.WriteLine(1 == s1.CompareTo(s2));

                for (int i = 0; i < stu.Count; i++)
                    Console.WriteLine(stu[i]);
                Console.WriteLine("----------------------");

                stu.Sort();

                for (int i = 0; i < stu.Count; i++)
                    Console.WriteLine(stu[i]);
            }
        }

    }

}
