using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.DataTypesConversion
{
    class Program
    {
        static void Main()
        {
            // Implicit Conversion, adalah konversi yang dilakukan oleh compiler
            // Explicit Conversion, adalah konversi yang dilakukan oleh kita sendiri, dikarenakan
            // compiler tidak bisa mengkonversinya
            // ada 2 cara untuk melakukan Explicit conversion
            // 1. menggunakan type cast (type data). contoh = (int), (string), (double)
            // 2. menggunakan convert class. contoh = Convert.ToString(), Convert.ToInt32()
            
            float f = 12123123123123.45F;

            int i = (int)f;

            // int i = Convert.ToIn32(f);

            Console.WriteLine(i);

            // Parse() dan TryParse()
            string Angka = "1009";
            // Parse(), akan mengembalikan exception jika value tidak bisa di konversi
            // jika bisa, maka akan mengembalikan hasil conversi
            //int num = int.Parse(Angka);
            //Console.WriteLine(num);

            // TryParse(), akan memgembalikan boolean true jika value berhasil di konversi
            // jika tidak maka false. TryParse() memiliki 2 argument. pertama adalah string yang ingin di konversi
            // kedua adalah variabel wadah untuk hasil konversi
            int Result = 0;
            bool IsConversion = int.TryParse(Angka, out Result);

            if (IsConversion)
                Console.WriteLine(Result);
            else
                Console.WriteLine("Please enter valid number");
        }
    }
}
