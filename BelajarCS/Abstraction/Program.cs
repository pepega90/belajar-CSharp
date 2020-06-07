using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Abstraction
{
    /* gunakan abstract keyword untuk membuat class abstract
     * abstract adalah class yang belum complete maka dari itu kita tidak bisa membuat instance dari abstract class
     * abstract class hanya bisa dijadikan base class. tidak bisa menjadi derived class (kelas turunan)
     * abstract class tidak bisa di sealed (sealed keyword adalah cara agar suatu class tidak bisa di inheritance)
     * abstract class bisa berisikan method, properti, indexers, events etc. tetapi tidak wajib
     * non abstract class melakukan inheritance ke class absctract harus berisikan implement dari member abstract class
     */

    /* Perbedaan abstract dengan Interface
     * abstract bisa memiliki implement member, sedangkan interface tidak bisa dan hanya bisa pendeklarasiannya saja
     * abstract bisa meiliki field (variabel) sedangkan interace tidak bisa
     * abstract bisa inherit dari abstract class lainnya dan interface, sedangkan interface hanya bisa inherit dari interface yang lain
     * abstract member bisa memiliki access modifier, sedangkan interace tidak bisa sama sekali
     * abstract member private by default, interface member public by default
     */

    public interface IOrang
    {
        void Human();
    }

    public abstract class Customer : IOrang
    {
        public void Print()
        {
            Console.WriteLine("print method");
        }

        public abstract void Human();
    }

    // jika suatu class tidak ingin implement member dari abstract class, maka kita bisa memberikan
    // abstract keyword di depannya
    public class Program : Customer
    {
        // untuk melakukan implement terhadap abstract member, gunakan keyword override
        //public override void Print()
        //{
        //    Console.WriteLine("Print method from abstract classes");
        //}

        public override void Human()
        {
            Console.WriteLine("Iam Human");
        }

        static void Main(string[] args)
        {
            Customer p = new Program();

            p.Print();
            p.Human();
        }
    }
}
