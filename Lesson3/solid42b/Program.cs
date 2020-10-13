using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex96
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;


    public class DynamicStringArray : IEnumerable
    {
        String[] arr;
        public int Count { get; private set; }
        int capacity = 2;

        public DynamicStringArray()
        {
            arr = new string[capacity];
        }

        private void growingArray()
        {
            capacity += capacity;
            String[] temp = new String[capacity];
            for (int i = 0; i < arr.Length; i++)
                temp[i] = arr[i];
            arr = temp;
        }

        public void Add(String obj)
        {
            if (Count >= capacity)
                growingArray();

            arr[Count] = obj;
            Count++;
        }


        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(arr, Count);
        }
    }

    public class MyEnumerator : IEnumerator
    {
        string[] arr;
        int index = -1;
        int count;
        public MyEnumerator(string[] arr, int count)
        {
            this.arr = arr;
            this.count = count;
        }

        public object Current
        {
            get { return arr[index]; }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= count)
            {
                index = -1;
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            DynamicStringArray arr = new DynamicStringArray();
            for (int i = 0; i < 5; i++)
                arr.Add("number " + i);

            foreach (string item in arr)
            {
                foreach (string item2 in arr)
                {
                    Console.Write(item2 + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
