using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelajarCS.DiffrenceConvertStringToString
{
    /* Perbedaan dari Convert.ToString() dengan ToString() method
     * Convert.ToString() menangani tipe data null sedangkan
     * ToString() tidak dan ketika kita memberikan tipe data null, dia akan melempar Refrence exception
     * tergantung pada jenis arsitektur aplikasi dan apa yang ingin Anda capai, 
     * Anda memilih salah satu dari yang lain
     */
    class Program
    {
        static void Main()
        {
            Customer c1 = null;
            string str = c1.ToString();
            Console.WriteLine(str);
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}
