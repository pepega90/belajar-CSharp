using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.MultiCastDelegates
{
    /* Multicast delegate adalah delegate yang merefrensikan lebih dari satu function
     * ketika kita invoke multicast delegate, semua function yang kita pointing (tunjuk) akan di invoked
     * ada 2 cara untuk membuat multicast delegate, tergantung dari approach yang kita gunakan
     * + atau += untuk register method dengan delegate
     * - atau -= untuk un-register method dengan delegate
     * catatan: multicast delegate akan meng-invoke function dari urutan kita merefrensikannya
     * jika delegate mempunyai return type yang lain (int, string, etc) selain void dan itu adalah multicast delegate. maka hanya function terakhir
     * saja yang akan me-return valuenya (ini juga berlaku jika delegate mempunyai output parameter)
     */
    public delegate void SampleDelegate(out int number);

    class Program
    {
        static void Main()
        {
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethod);
            //del2 = new SampleDelegate(SampleMethod2);
            //del3 = new SampleDelegate(SampleMethod3);

            //del4 = del1 + del2 + del3;
            //del4(); // <= del4 menjadi multicast delegate, karena ia pointing ke 3 function yang berbeda
            // urutan function yang sudah di register di delegate, disebut invocation list
            
            // jika kita hanya ingin memiliki satu instance tetapi ingin menjadikannya multicast delegate
            // kita bisa gunakan tanda +=
            SampleDelegate del1 = new SampleDelegate(SampleMethod);
            del1 += SampleMethod2;

            int numOutput = -1;
            del1(out numOutput);
            Console.WriteLine("return value multicast delegate = {0}", numOutput);
        }

        public static void SampleMethod(out int num)
        {
            num = 1;
        }

        public static void SampleMethod2(out int num)
        {
            num = 2;
        }


    }
}
