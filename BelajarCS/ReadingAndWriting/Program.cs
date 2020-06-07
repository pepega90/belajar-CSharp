using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.ReadingAndWriting
{
    class Program
    {
        static void Main()
        {
            // Note: C# is Case Sensitive Programming Language
            // Console adalah salah satu dari System Class
            // WriteLine(), method untuk kita menampilkan sesatu ke console
            Console.Write("Please enter your first name = ");

            // ReadLine(), method untuk kita menerima input dari console
            // by default ReadLine() method mengembalikan tipe data string
            string FirstName = Console.ReadLine();

            Console.Write("Please enter your last name = ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hai {0}, {1}", FirstName, LastName);
        }
    }
}
