using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid54
{
    public class PointCollection<T> : IEnumerable<T>
    {
        private List<T> arPoints = new List<T>();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        { return arPoints.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator()
        { return arPoints.GetEnumerator(); }
        public void AddPoint(T p) { arPoints.Add(p); }

    }
    class program
    {
        public static void Main() //GenericsDemo()
        {
            Console.WriteLine("Generics Demo");
            List<Car> carList = new List<Car>();
            carList.AddRange(new Car[] { new Car("Fred", 90), new Car("Sam", 100), new Car("Joe", 190) });
            Console.WriteLine("Items in list {0}", carList.Count);
            foreach (Car c in carList)
            {
                Console.WriteLine("Car pet name {0}", c.PetName);
            }
            Console.WriteLine("Insert a new car");
            carList.Insert(2, new Car("TheNewCar", 0));
            Console.WriteLine("Items in list {0}", carList.Count);
            object[] arrayOfCars = carList.ToArray();
            for (int i = 0; i < arrayOfCars.Length; i++)
            {
                Console.WriteLine("Car pet name {0}", ((Car)arrayOfCars[i]).PetName);
            }
            int a = 10;
            int b = 90;
            Swap(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
            string s1 = "hello"; string s2 = "there";
            Swap(ref s1, ref s2);
            Console.WriteLine("{0} {1}", s1, s2);

            Point<int> intPoint = new Point<int>(10, 10);
            Console.WriteLine(intPoint.ToString());
            intPoint.ResetPoint();
            Console.WriteLine(intPoint.ToString());
            Point<double> dblPoint = new Point<double>(10.4, 5.6);
            Console.WriteLine(dblPoint.ToString());
            dblPoint.ResetPoint();
            Console.WriteLine(dblPoint.ToString());

            PointCollection<Point<int>> myIntPoints = new PointCollection<Point<int>>();
            myIntPoints.AddPoint(new Point<int>(3, 4));
            myIntPoints.AddPoint(new Point<int>(5, 6));
            foreach (Point<int> point in myIntPoints)
            {
                Console.WriteLine("[{0}, {1}]", point.X, point.Y);
            }
        }

    }
}
