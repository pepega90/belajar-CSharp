using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.AccessModifier
{
    /* Private = Hanya bisa di akses sebatas di class itu sendiri
     * Public = Bisa di akses dimana saja
     * Protected = Hanya bisa di akses oleh kelas turunan yang inherit dari base class, yang mempunyai protected member
     */
     public class Customer
    {
        protected int ID;
        //private int _id;

        //public int ID
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}
    }

    public class Corporate : Customer
    {
        public void printId()
        {
            
            Corporate cc = new Corporate();
            cc.ID = 101;
            // jika kita tidak ingin membuat object, dari corporate class kita bisa akses dengan cara seperti dibawah
            //base.ID;
            //this.ID;
        }
    }

    class Program
    {
        static void Main()
        {
            Corporate c = new Corporate();
            Console.WriteLine(c);
        }
    }
}
