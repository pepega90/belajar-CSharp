using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BelajarCS.ThreadStartDelegate
{
    /* ThreadStart
     * untuk membuat Thread, kita bisa membuat instance dari Class Thread lalu
     * kita passing nama function di constructor yang kita mau thread untuk eksekusi
     * Kenapa delegate harus di passing sebagai parameter di Class Thread constructor?
     * tujuan membuat utas adalah untuk menjalankan suatu fungsi.
     * delegate adalah type safe function pointer, artinya menunjuk ke fungsi yang harus dijalankan thread. singkatnya, semua thread membutuhkan titik masuk untuk memulai eksekusi. 
     * setiap thread yang kita buat akan membutuhkan titik entri yang didefinisikan secara jelas, yaitu sebuah penunjuk ke fungsi di mana mereka harus memulai eksekusi.
     * jadi thread selalu membutuhkan delegate.
     * 
     */
    class Program
    {
        static void Main()
        {
            //Thread t1 = new Thread(new ThreadStart(Number.PrintNumber));
            //Thread t1 = new Thread(delegate () { Number.PrintNumber(); });
            //Thread t1 = new Thread(() => Number.PrintNumber());
            /* Thread function tidak selamanya harus static, kita juga bisa membuat menjadi function biasa
             * lalu membuat instance dari class tersebut dan memanggil function tersebut
             */
            Number num1 = new Number();
            Thread t1 = new Thread(num1.PrintNumber);
            t1.Start();
        }
    }

    class Number
    {
        public void PrintNumber()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
