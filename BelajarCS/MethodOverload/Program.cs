using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.MethodOverload
{
    class Program
    {
        // method overload, dimana kita bisa memiliki method dengan nama sama, namun memiliki signature yang berbeda
        // misalnya parameternya berbeda, jumlah paramternya, type parameter etc. kita tidak bisa membuat method overload hanya berdasarkan return type yang berbeda
        // ataupun params modifier

        static void Main()
        {
            Add(2, 3);
        }

        public static void Add(int val1, int val2, params int[] val3)
        {
            Console.WriteLine("Sum = {0}", val1 + val2);
        }

        public static void Add(int val1, int val2)
        {
            Console.WriteLine("Sum = {0}", val1 + val2);
        }
    }
}
