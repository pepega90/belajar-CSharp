using System;
using System.Linq;

namespace BelajarCS.Inheritance.Program
{

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTime : Employee
    {
        // jika kita ingin menyembunyikan class member, gunakan new keywords
        public new void PrintFullName()
        {
            // gunakan base keyword, untuk menggunakan base class member
            //base.PrintFullName();
            Console.WriteLine("FistName = " + FirstName + " " + LastName + " -Construcotr");
        }
    }

    public class FullTime : Employee
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            FullTime pe = new FullTime();
            pe.FirstName = "Aji";
            pe.LastName = "Mustofa";
            pe.PrintFullName();

            // kita bisa juga menggunakan base class sebagai type, lalu instantiated ke kelas turunan
            Employee po = new PartTime();
            po.FirstName = "Nur";
            po.LastName = "Big boutty";
            // kita bisa menggunakan type cast, untuk memanggil base class member
            //((Employee)po).PrintFullName();
            po.PrintFullName();
        }
    }
}
