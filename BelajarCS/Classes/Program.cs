using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Classes
{
    class Customer
    {
        string _firstName;
        string _lastName;

        // disini kita membuat overload constructor (kita juga bisa membuat method overload), jadi jika customer tidak memberikan argument
        // maka value ini yang akan di berikan
        public Customer() : this("No FirstName", "No LastName")
        {

        }
        // constructor, memiliki nama yang sama dengan class itu sendiri. kita tidak selalu wajib
        // membuat constructor di setiap class

        public Customer(string FirstName, string LastName)
        {
            // this keyword, refrence ke class saat ini
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name = {this._firstName} {this._lastName}");
        }

        // destructor, memiliki nama yang sama dengan class. tidak bisa memiliki parameter
        // biasanya digunakan untuk clean up code dan akan di invoke secara otomatis ketika class
        // destroyed
        ~Customer()
        {
            // Clean Up Code
        }
    }

    class Program
    {
        static void Main()
        {
            // gunakan new keyword untuk membuat instance dari class
            Customer c1 = new Customer();
            c1.PrintFullName();

            Customer c2 = new Customer("A", "Bi");
            c2.PrintFullName();
        }
    }
}
