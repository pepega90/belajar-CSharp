using System;

namespace AssemblyOne
{
    /* Access Modifer Part 2 (Interal dan Protected Internal)
     * Internal = hanya punya akses di project assembly itu sendiri
     * Protected Internal = punya akses di assembly mana saja, dan bisa di akses di kelas turunan dari base class assembly
     */
    public class asambeliOne
    {
        //protected internal int ID = 101;

        public void Print()
        {
            Console.WriteLine("Hello from asembli one");
        }
    }

    //public class asambel
    //{
    //    //public void sampleMethod()
    //    //{
    //    //    asambeliOne one = new asambeliOne();
    //    //    Console.WriteLine(one.ID);
    //    //}
    //}
}
