using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Attributes
{
    /* Atribut memungkinkan Anda untuk menambahkan informasi deklaratif ke program Anda. 
     * informasi ini kemudian dapat ditanyakan saat runtime menggunakan refleksi
     * Ada beberapa artibute yang disediakan oleh .NET, dan kita juga bisa membuat atribute kita sendiri
     * Obsolete = menandai tipe dan tipe anggota yang kedaluwarsa
     * WebMethod = untuk mengekspos metode sebagai metode layanan web xml
     * Serializable = menunjukkan bahwa kelas dapat diserialisasi
     * kita bisa menyesuaikan atribut menggunakan parameter
     * atribue class, inherit dari System.Attribute base class
     */
    class Attributes
    {
        static void Main()
        {
            Calculator.Add(10,20);
        }
    }

    public class Calculator
    {
        // cara kita memberikan atribute
        [Obsolete("Use Add(List<int> num) Method")]
        public static int Add(int fn, int sn)
        {
            return fn + sn;
        }

        public static int Add(List<int> num)
        {
            int sum = 0;
            foreach (int number in num)
            {
                sum += number;
            }
            return sum;
        }
    }
}
