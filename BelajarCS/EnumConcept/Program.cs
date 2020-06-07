using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.EnumConcept
{
    /* Dengan enum kode program kita menjadi lebih maintainable dan readable
     * dasar value enum adalah integer. value dari enum di mulai dari 0 dan di increment setiap valuenya
     * kita bisa mengganti default setiap value dari enum
     * enum adalah value types
     */
    class Program
    {
        static void Main()
        {
            // enum tidak bisa melakukan konversi secara implicit, kita harus lalukan explicit konversi
            // dari integer ke type dari enum tersebut, dan sebaliknya
            //Gender gender = (Gender)3;
            //int number = (int)Gender.Male;

            // kita tidak bisa meng-assign enum dengan enum lain, walapun secara default num memiliki type integer
            // agar bisa kita harus melakukan explicit konversi ke type enum yang ingin dituju
            //Gender gender = Season.Winter; <= compile error
            //Gender gender = (Gender)Season.Winter; <= work, karena kita lakukan explicit konversi ke type dari enum

            // untuk mendapatkan type dari gender enum, kita gunakan method typeof
            // untuk mendapatkan value dari suatu enum. kita gunakan method GetValues() dari Enum class
            //short[] values = (short[])Enum.GetValues(typeof(Gender));

            //foreach (short val in values)
            //{
            //    Console.WriteLine(val);
            //}

            //// untuk mendapatkan value dari suatu enum. kita gunakan method GetNames() dari Enum class
            //string[] names = (string[])Enum.GetNames(typeof(Gender));

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }

    // cara membuat enum adalah dengan keyword "enum" e kecil, jika menggunakan E besar itu adalah Enum Class
    // ini cara kita mengganti underlying value di enum. mirip-mirip cara inheritance
    // secara default enum underlying type adalah integer
    public enum Gender
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }

    public enum Season
    {
        Winter = 1,
        Sprint = 2,
        Summer = 3
    }
}
