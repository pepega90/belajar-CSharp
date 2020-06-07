using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics memungkinkan penggunaan kembali kode di berbagai jenis tipe data
            // kita bisa membuat method, class, interface, delegates juga menjadi generics
            bool sama = Calculator<int>.sama(9, 9);

            if (sama)
            {
                Console.WriteLine("sama");
            }
            else
            {
                Console.WriteLine("tidak sama");
            }
        }
    }

    public class Calculator<Tipe>
    {
        public static bool sama(Tipe val1, Tipe val2)
        {
            return val1.Equals(val2);
        }
    }

}
