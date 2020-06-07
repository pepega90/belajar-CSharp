using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace BelajarCS.PerformanceMultithreadingProgram
{
    class Program
    {
        public static void AngkaGenap()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum dari angka genap = " + sum);
        }

        public static void AngkaGanjil()
        {
            double sum = 0;
            for (int i = 0; i < 50000000; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            Console.WriteLine("Sum dari angka ganjil = " + sum);
        }

        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            AngkaGenap();
            AngkaGanjil();
            stopwatch.Stop();
            Console.WriteLine("Total miliseconds without multiple threads = " + stopwatch.ElapsedMilliseconds);

            stopwatch = Stopwatch.StartNew();
            Thread t1 = new Thread(AngkaGenap);
            Thread t2 = new Thread(AngkaGanjil);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total miliseconds with multiple threads = " + stopwatch.ElapsedMilliseconds);

        }
    }
}
