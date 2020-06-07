using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BelajarCS.ParameterizedThreadStart_delegate
{
    /* ParameterizedThreadStart delegate
     * adalah ketika kita ingin mengirim data ke Thread
     * ketika kita tidak ingin mengirim data apa pun, kita bisa gunakan ThreadStart
     * ParameterizedThreadStart delegate, memiliki parameter object
     */

    /* Part 91 Retrieving data from Thread function using callback method
     */
    public delegate void SumNumCallback(int sum);

    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = {0}", sum);
        }

        static void Main()
        {
            Console.WriteLine("Please enter target = ");
            int target = int.Parse(Console.ReadLine());

            SumNumCallback callback = new SumNumCallback(PrintSum);

            Number num1 = new Number(target, callback);
            //ParameterizedThreadStart parameterizedThreadStart = 
            //    new ParameterizedThreadStart(num1.PrintNumber);
            Thread t1 = new Thread(num1.PrintNumber);
            t1.Start();
        }
    }

    class Number
    {
        /* Cara agar kita bisa mempertahankan type safe manner ketika passing data ke thread
         * kita bisa membuat private field yang value nya akan di isi menggunakan constructor dari class
         * setelah itu kita jadikan private field tadi sebagai target dari PrintNumber() method
         */
        int _target;
        SumNumCallback _callbackMethod;

        public Number(int target, SumNumCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        public void PrintNumber()
        {
            /* Catatan
             * menggunakan ParameterizedThreadStart delegate dan Thread.Start(object) method untuk memberikan data
             * ke thread function sesungguhnya tidak aman karena mereka beroperasi pada tipe data objek dan semua jenis data dapat dikirimkan.
             * jika kita mengubah parameter dari method PrintNumber() ke int, compiler akan memberikan error karena signaturenya tidak sama
             * dengan signature dari ParameterizedThreadStart delegate yang dimana signaturenya adalah object
             */
            int sum = 0;
            for (int i = 1; i <= this._target; i++)
            {
                sum += i;
            }
            if (_callbackMethod != null)
            {
                _callbackMethod(sum);
            }
        }
    }
}
