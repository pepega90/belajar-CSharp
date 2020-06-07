using System;
using System.Linq;

namespace BelajarCS.OperatorMath.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            /* 
             + = pertambahan
             - = pengurangan
             * = perkalian
             / = pembagian
             pembagian dengan 0 akan menyebabkan error exception
             hasil pembagian akan dibulatkan ke bawah (kita bisa menggunakan Math.Round() untuk pembulatan terdekat)
             % = modulus (sisa hasil bagi)

            kita harus menggunakan tipe data yang sama ketika ingin melakukan operasi aritmatik
             */
            int a = 10;
            int b = 4;
            int c;

            //pertambahan
            c = a + b;
            Console.WriteLine("Hasil Pertambahan {0}",c);

            // pengurangan
            c = a - b;
            // c = b - a hasilnya -6
            Console.WriteLine("hasil pengurangan {0}", c);

            //perkalian
            c = a * b;
            Console.WriteLine("hasil perkalian {0}", c);

            //pembagian
            c = a / b;
            // c = b / a hasilnya 0, hasil aslinya 0.4 namun karena pembagian akan membulatkan kebawah maka hasilnya 0
            Console.WriteLine("hasil pembagian {0}", c);

            //modulus 
            c = a % b;
            Console.WriteLine("hasil modulus {0}", c);

            // contoh ketika kita menggunakan tipe data yang berbeda
            int d = 10;
            double e = 3;
            double f;
            f = d + e;
            Console.WriteLine(f);
            
        }
    }
}
