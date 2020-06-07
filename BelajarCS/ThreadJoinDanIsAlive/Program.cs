using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BelajarCS.ThreadJoinDanIsAlive
{
    /* Thread.Join dan Thread.IsAlive functions
     * Join akan memblock thread saat ini dan membuatnya menunggu hingga thread yang join tadi selesai
     * join method juga punyai overloaded dimana kita bisa memberikan spesifik waktu dalam hitungan miliseconds.
     * join mengembalikan boolean, jika true artinya thread sudah berhenti jika tidak maka false
     * join juga berguna ketika kita ingin melakukan wait and collect data dari thread atau melakukan clean up pada code ketiak thread sudah complete
     * 
     * IsAlive, mengembalikan boolean, true jika thread masih berjalan (executing) jika tidak maka false
     */
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Main started");
            Thread t1 = new Thread(Thread1);
            t1.Start();

            Thread t2 = new Thread(Thread2);
            t2.Start();

            if (t1.Join(1000))
            {
                Console.WriteLine("thread 1 complete"); 
            }
            else
            {
                Console.WriteLine("thread 1 has not complete is 1 second");
            }

            t2.Join();
            Console.WriteLine("thread 2 complete");

            for (int i = 1; i <= 10; i++)
            {
                if (t1.IsAlive)
                {
                    Console.WriteLine("t1 thread is still executing");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("thread 1 complete");
                    break;
                } 
            }

            Console.WriteLine("Main complete");
        }
        public static void Thread1()
        {
            Console.WriteLine("Thread1 started");
            // Thread.Sleep(), menunda thread selama waktu yang di tentukan, argument dalam hitungan miliseconds
            Thread.Sleep(5000);
            Console.WriteLine("thread1 function is about to return");
        }
        public static void Thread2()
        {
            Console.WriteLine("Thread2 started");
        }
    }
}
