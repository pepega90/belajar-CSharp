using System;
using System.Linq;

namespace BelajarCS.IncrementAndDecrement.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            // increment operator (++) menambah value 1 nilai
            // jika kita menaruh ++ di awal sebuah variabel dia akan me-return value setelah ditambahkan
            // int a = 5; ++a akan mengembalikan 6
            // jika kita menaruh ++ di belakang sebuah variabel dia akan me-return value sebelum ditambahkan
            // int a = 5; a++ akan mengembalikan 5
            // keduanya akan mengembalikan 6, di baris sesudah ditambahkan

            // contoh increment
            //int a = 10;
            //Console.WriteLine(++a);  11
            //Console.WriteLine(a);  11

            //Console.WriteLine(a++); 10
            //Console.WriteLine(a); 11

            //a++;
            //Console.WriteLine(a); 11
            //++a;
            //Console.WriteLine(a); 12

            // decrement operator (--) mengurangi value 1 nilai
            // jika kita menaruh -- di awal sebuah variabel dia akan me-return value setelah dikurangi
            // int a = 5; --a akan mengembalikan 4
            // jika kita menaruh -- di belakang sebuah variabel dia akan me-return value sebelum dikurangi
            // int a = 5; a-- akan mengembalikan 5
            // keduanya akan mengembalikan 4, di baris sesudah dikurangi

            // contoh decrement
            //int a = 10;
            //Console.WriteLine(--a); 9
            //Console.WriteLine(a); 9

            //Console.WriteLine(a--); 10
            //Console.WriteLine(a); 9

            //a--;
            //Console.WriteLine(a); 9
            //--a;
            //Console.WriteLine(a); 8


        }
    }
}
