using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BelajarCS.OptionalParameter
{
    /* Optional Parameter
     * ada 4 cara untuk membuat optional parameter
     * 1. Menggunakan parameter arrays
     * 2. method overloaded
     * 3. memberikan default parameter
     * 4. menggunakan OptionalAttribute yang ada di System.Runtime.InteropServices namespace
     */
    class Program
    {
        static void Main()
        {
            // contoh cara pertama
            //AddNumber(10, 20, , 5, 10, 40 );

            // contoh cara kedua
            //AddNumber(10, 20, new int[] { 20, 20, 30 });

            // contoh cara ketiga
            //AddNumber(10, 20, new int[] { 5, 4, 6 });

            //named parameter
            //NamedParam(1, c: 2);
            
            // contoh cara keempat
            AddNumber(10, 20, new int[] { 1, 2, 3 });
        }

        // contoh method untuk cara pertama
        //public static void AddNumber(int fn, int sn, params object[] resNumber)
        //{
        //    int result = fn + sn;
        //    if (resNumber != null)
        //    {
        //        foreach (int a in resNumber)
        //        {
        //            result += a;
        //        }

        //    }
        //    Console.WriteLine("Sum = {0}", result);
        //}

        // cara kedua dengan method overloaded
        //public static void AddNumber(int fn, int sn)
        //{
        //    AddNumber(fn, sn, null);
        //}

        //public static void AddNumber(int fn, int sn, int[] resNumber)
        //{
        //    int result = fn + sn;
        //    if (resNumber != null)
        //    {
        //        foreach (int a in resNumber)
        //        {
        //            result += a;
        //        }

        //    }
        //    Console.WriteLine("Sum = {0}", result);
        //}

        // cara ketiga dengan default parameter
        //public static void AddNumber(int fn, int sn, int[] resNumber = null)
        //{
        //    int result = fn + sn;
        //    if (resNumber != null)
        //    {
        //        foreach (int a in resNumber)
        //        {
        //            result += a;
        //        }

        //    }
        //    Console.WriteLine("Sum = {0}", result);
        //}

        // tambahan: kita bisa juga gunakan named parameter
        //public static void NamedParam(int a, int b = 10, int c = 20)
        //{
        //    Console.WriteLine("a = {0}", a);
        //    Console.WriteLine("b = {0}", b);
        //    Console.WriteLine("c = {0}", c);
        //}

        // cara keempat dengan optional attribute
        public static void AddNumber(int fn, int sn, [Optional] int[] resNumber)
        {
            int result = fn + sn;
            if (resNumber != null)
            {
                foreach (int a in resNumber)
                {
                    result += a;
                }

            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}
