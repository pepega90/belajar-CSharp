using System;
using System.Linq;

namespace BelajarCS.String.Program
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            // beberapa cara penggabungan string di C#   
            string firstName = "aji";
            string lastName = " mustofa";
            // concatination, penggabungan string dengan tanda +
            Console.WriteLine(firstName + lastName);
            // placeholder
            Console.WriteLine("{0}{1}", firstName, lastName);
            // string interpolation
            Console.WriteLine($"{firstName}{lastName}");

            decimal angkaDecimal = 12312.123123M;
            decimal decim2 = 123123.442312M;
            // ToString(), method untuk mengconvert numeric type ke string type
            string totalDecimal = (angkaDecimal + decim2).ToString();
            Console.WriteLine(totalDecimal);

            // penggunakan escape karakter
            Console.WriteLine("Dia berkata \"Aku suka dinda\" namun \ndinda bilang \"aku sudah bertunangan\"");
        }
    }
}
