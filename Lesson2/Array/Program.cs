﻿using System;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            int[] arr;
            int a = 10;
            arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            int[] arr2 = arr;
            arr2[5] = -1;
            Console.WriteLine(arr[5]);

            //System.Array arr3;
            //arr3.SetValue(6, 3);
            
        }
    }
}
