using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BelajarCS.MethodsParameter
{
    class Program
    {
        /* Passing by value / by refrence
         * jika kita meneruskan variabel by value, mereka akan menunjuk ke lokasi memory yang berbeda
         * maka dari itu jika salah satu melakukan operasi, itu tidak akan ngefek ke variabel lainnya
         * 
         * jika kita meneruskan variabel by refrence, mereka akan menunjuk ke lokasi memory yang sama
         * maka dari itu jika salah satu melakukan operasi, itu akan berefek pada variabel yang lainnya
         */
        static void Main()
        {
            int[] num = new int[3] { 101, 102, 103 };

            // jika kita meggunakan keyword "params" di parameter method kita,
            // parameter kita bisa menjadi optional
            //paramMethod();
            //paramMethod(num);
            paramMethod(1, 2, 3, 4, 5);

        }

        /* Parameters Array
         * untuk membuat parametar array menggunakan "params" keyword
         * kita hanya bisa memiliki satu (1) parameter array
         * dan jika kita memiliki banyak parameter, kita harus menaruh parameter array di akhir
         */
        public static void paramMethod(params int[] Angka)
        {
            Console.WriteLine("Total Angka = {0}", Angka.Length);
            foreach (int i in Angka)
            {
                Console.WriteLine(i);
            }
        }
    }
}
