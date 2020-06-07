using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace BelajarCS.ProtectedResourcesMultithreading
{

    class Program
    {
        static int Total;
        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread t1 = new Thread(Program.AddOneMillion);
            Thread t2 = new Thread(Program.AddOneMillion);
            Thread t3 = new Thread(Program.AddOneMillion);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Total = {0}", Total);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }

        // kita buat object untuk melakukan cara lock
        static object _lock = new object();

        public static void AddOneMillion()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                /* Dengan thread kita tidak mendapatkan hasil yang konsisten yaitu 3 miliar
                 * karena operator ++ tidak aman untuk thread, namun kita bisa mencegah ini
                 * dengan menggunakan Interlocked.Increment() method. method ini berguna untuk meng-spesifik variabel dan menyimpan
                 * hasilnya sebagai operasi atom
                 * 
                 * cara lainnya kita bisa gunakan object lock, yang hanya 1 thread yang bisa masuk ke dalam lock tersebut
                 */
                //Interlocked.Increment(ref Total);
                // Secara performa menggnakan interlocked class masih bagus di banding lock
                // karena ketika kita melakukan lock, hanya ada 1 thread yang masuk
                // interlocked class juga memiliki method selain increment, seperti decrement add dll

                // part 94, Monitor vs Lock in C#
                // Monitor memiliki mekanismen yang sama dengan lock
                // pada dasarnya lock adalah shortcut dari monitor
                Monitor.Enter(_lock);
                try
                {
                    Total++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }
    }
}
