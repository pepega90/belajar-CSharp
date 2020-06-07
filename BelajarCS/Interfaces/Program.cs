using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Interfaces
{
    /* Kita bisa membuat interfaces dengan keyword "interface", seperti class interface bisa
     * punya properti, method, delegats atau events. tetapi hanya pendeklarasiannya dan bukan implementasinya
     * interface by default adalah public, dan kita tidak bisa memberikan access modifier
     * interface tidak bisa memiliki field (hanya properti, method , event etc)
     * jika class atau struct inherit interface, mereka harus memiliki properti atau pun method implement yang ada di interface tersebut
     * class atau struct bisa melakukan inheritace lebih dari satu interface
     * interface bisa melakukan inheritance ke interface lain
     * kita tidak bisa membuat instance dari interface
     * Penamaan interface di awali dengan "I" kapital
     */
    //interface ICustomer1
    //{
    //    void Print();
    //}

    //interface ICustomer2 : ICustomer1
    //{
    //    void Print2();
    //}

    //public class Customer : ICustomer2
    //{
    //    public void Print2()
    //    {
    //        Console.WriteLine("Print2 method");
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("Print Method");
    //    }
    //}

    // Explicit interfaces implementations
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    class Program : I1, I2
    {
        // ketika kita ingin melakukan explicit interface member, kita tidak diperbolehkan menggunakan
        // access modifier lalu kita menggunakan nama interface tersebut dan guanakn dot notation
        // untuk mengakses member interface tersebut
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }

        static void Main(string[] args)
        {
            // kita bisa membuat refrence variabel dari interface, lalu pointing ke class turunan
            //ICustomer1 c = new Customer();
            //c.Print();
            Program c = new Program();
            // ketika kita melakukan explicit interface, kita tidak bisa memanggil member tersebut
            // lewat class refrence variabel melainkan interface refrence variabel
            //I1 c2 = new Program(); <= contoh interface refrence variabel
            //c2.InterfaceMethod(); <= I2 interface method akan di invoke
            //c.InterfaceMethod(); <= ini tidak bisa, dan akan terjadi compile error
            //((I1)c).InterfaceMethod(); <= atau melalui type casting 

            // default implementations. kita implement interface pertama secara normal
            // namun interface kedua explicit
            c.InterfaceMethod();
            ((I2)c).InterfaceMethod();
        }
    }
}
