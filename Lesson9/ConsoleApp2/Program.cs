using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }

            public Student() { }

            public Student(Student other)
            {
                Id = other.Id;
                Name = other.Name;
                Age = other.Age;
                Grades.AddRange(other.Grades);//work for list of value types;

                //for list of reference type
                //foreach (int g in other.GradesGrades)
                //{
                //    Grades.Add(g);
                //}

            }
        }

        class DataSource
        {
            public List<Student> listStudents;
        }

        class Program
        {

            static List<Student> initList()
            {
                return new List<Student>
             {
                new Student{Name = "dina", Id = 1, Grades = new List<int>{45,83,80},  Age = 29} ,
                new Student{Name = "gila",  Id = 2, Grades = new List<int>{80,90,80},  Age = 26} ,
                new Student{Name = "yoav",  Id = 3, Grades = new List<int>{90,90,85},  Age = 29} ,
                new Student{Name = "dan",   Id = 4, Grades = new List<int>{100,75,80}, Age = 29} ,
                new Student{Name = "ron",   Id = 5, Grades = new List<int>{40,80,80},  Age = 34} ,
                new Student{Name = "meir",  Id = 6, Grades = new List<int>{50,13,80},  Age = 20} ,
                new Student{Name = "tom",   Id = 7, Grades = new List<int>{55,100,80}, Age = 29} ,
                new Student{Name = "david", Id = 8, Grades = new List<int>{90,70,80},  Age = 22} ,
                new Student{Name = "dor",   Id = 9, Grades = new List<int>{100,60,80}, Age = 22} ,
             };
            }

            static void Main(string[] args)
            {
                DataSource ds = new DataSource();
                ds.listStudents = initList();

                //option 1
                List<Student> listAvg = getStudentsWithAvgGreaterThan(75).ToList();

                //option 2
                foreach (Student st in getStudentsWithAvgGreaterThan(75))
                {
                    Console.WriteLine(st.Name);
                }

            }

            static IEnumerable<Student> getStudentsWithAvgGreaterThan(double minAvg)
            {
                var v = from item in initList()
                        let average = item.Grades.Average()
                        where average < minAvg
                        orderby item.Id
                        select new Student(item);//use copy ctor to create copy of each student

                return v;
            }




        }
    }
