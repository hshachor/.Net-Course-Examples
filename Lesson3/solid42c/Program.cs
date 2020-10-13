
namespace Ex97
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;


    public class DynamicStringArray : IEnumerable, IEnumerator
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
            return this;
        }

        int index = -1;
        public object Current
        {
            get { return arr[index]; }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= Count)
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
