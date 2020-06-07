using System;
using System.Linq;

namespace BelajarCS.ExplicitConversion.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            int x = 8;
            double y = 3.42;
            /*
             disini kita secara explicit mengubah tipe data dari variabel x dari integer ke double
             namun kita hanya mengubahnya di baris code itu sementara saja, kita tidak mengubah tipe data yang sebenarnya
             */
            double sum = y + (double)x;
            Console.WriteLine(sum);
            Console.WriteLine("Variabel x akan tetap {0}", x);
        }
    }
}
