using System;
using System.Diagnostics;

namespace BelajarCS.Suffixes
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            // Suffix, 
            //Akhiran tipe data membantu kompiler untuk secara jelas mengidentifikasi tipe data dari nilai / literal apa pun. Ini juga membantu programmer C # untuk secara eksplisit menyatakan tipe data dari nilai / literal.
            /* 
             L: long
             D: double
             F: float
             M: decimal
             U: unsigned int
             UL: unsigned long
             */
            //decimal angkaDecimal = 34.34123423423M;
            long angkaLong = 42342342342342L;

            Console.WriteLine(angkaLong);
            Debug.WriteLine(angkaLong);
        }
    }
}
