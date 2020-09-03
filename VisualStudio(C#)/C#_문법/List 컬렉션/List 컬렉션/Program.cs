﻿using System;
using System.Collections.Generic;

namespace List_컬렉션
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Main1(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            PrintValues(a);

            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            a.RemoveAt(3);
            PrintValues(a);
        }

        private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine(" Count = {0}", a.Count);
            Console.WriteLine(" Capactiy = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }
    }
}
