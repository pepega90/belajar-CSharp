using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.StringAndStringBuilder
{
    /* Perbedaan System.String dan StringBuilder
     * System.String itu Immutable (kita tidak bisa mengubahnya secara langsung) sedangkan
     * StringBuilder itu Mutable (kita bisa mengubahnya secara langsung)
     * karena objek stringbuilder bisa berubah, mereka menawarkan kinerja yang lebih baik daripada objek string tipe system.string, 
     * ketika manipulasi string berat terlibat
     */
    class Program
    {
        static void Main()
        {

            //string userString = string.Empty;
            //for(int i = 1; i<= 100; i++)
            //{
            //    userString += i.ToString() + " ";
            //}
            //Console.WriteLine(userString);

            string userString = "C#";
            userString += " Video";
            userString += " Tutorial";
            userString += " for";
            userString += " Beginner";

            StringBuilder UserString = new StringBuilder("C#");
            UserString.Append(" Video");
            UserString.Append(" Tutorial");
            UserString.Append(" for");
            UserString.Append(" Beginner");

            Console.WriteLine(UserString.ToString());
        }
    }
}
