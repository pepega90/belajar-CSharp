using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.PartialMethods
{
    /* partial methods
    * 1. partial class atau partial struct bisa memiliki partial method
    * 2. partial method dibuat dengan keyword partial
    * 3. kita bisa memisah pendeklarasion partial method misal
    * a) di file pertama kita melakukan definisi method
    * b) di file kedua kita memberikan implement
    * 4. implementasi dari partial method itu optional, jika kita tidak melakukannya maka compiler akan menghilangkan signaturenya
    * 5. partial methods itu private by default
    * 6. akan terjadi compiler error jika kita tidak meng-include deklarasi dan implementasi secara bersamaan
    * 7. partial methods return type harus void
    * 8. signature dari deklarasi partial methods harus sama dengan implementasi
    * 9. partial methods harus di buat di class partial atau struct partial, jika non partial class atau struct membuat partial method maka akan terjadi error
    * 10.partial method hanya bisa memiliki satu implementasi, jika kita mencoba membuat implementasi lebih dari satu, maka akan terjadi error
    */
    class PartialMethods
    {
        static void Main()
        {
            SamplePartial spc = new SamplePartial();
            spc.PublicMethod();
        }
    }
}
