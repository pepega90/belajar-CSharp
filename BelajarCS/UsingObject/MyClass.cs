using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.UsingObject
{
    class MyClass
    {
        // disini kita membuat variabel
        //private int _val1;
        //private int _val2;
        //public int Value1;
        //public int Value2;

        /* property get = berguna untuk menerima nilai dari suatu variabel (biasanya variabelnya private)
         * property set = berguna untuk kita mengubah niali dari suatu variabel (biasanya variabelnya private)
         */

        /* jika kita ingin menggunakan auto implemented property kita harus mencantumkan get accessor
         dan secara tidak langsung kita membuat variabel
       */
        //public int Value1 { get; set; }
        //public int Value2 { get; set; }

        /* Class contructor
         * adalah method dengan nama yang sama dengan class itu sendiri
         * yang akan di jalankan setiap kita meng-instantiated object
         * class contructor juga bisa di overload
         */
        //public MyClass()
        //{
        //    Value1 = 6;
        //    Value2 = 4;
        //}

        private int _total;

        public int Total
        {
            get { return _total; }
            //set { _total = value; }
        }


        public MyClass(int Value1, int Value2)
        {
            // kita bisa menggunakan keyword this, jika parameter memiliki nama yang sama
            // karena keyword this, akan merefrensikan ke class saat ini
            // yang sebernarnya terjadi adalah 
            // MyClass.Value1 = Value1;
            // MyClass.Value2 = Value2;
            //this.Value1 = Value1;
            //this.Value2 = Value2;
            _total = addTwoInteger(Value1, Value2);
        }


        //public int Value1 { get; set; }

        //private int _value2;

        //public int Value2
        //{
        //    get { return _value2; }
        //    set { _value2 = value; }
        //}


        // disini kita mendeklarasi method (functions)
        //public void doMath()
        //{
        //    // this keyword, itu merefrensikan ke class saat ini (current class)
        //    Console.WriteLine(addTwoInteger(this.Value1, Value2));
        //}
        //// method overloading, dimana kita bisa memiliki method dengan nama yang sama
        //// namun melakukan code perform statement yang berbeda dan parameter yang berbeda juga
        //public int doMath(int value1, int value2)
        //{
        //    return addTwoInteger(value1, value2);
        //}

        //public int doMath(int value1, int value2, int maxTotal)
        //{
        //    int result = addTwoInteger(value1, value2);
        //    if (result < maxTotal)
        //    {
        //        result = maxTotal;
        //    }
        //    return result;
        //}

        // default parameter, tidak bisa digunakan di required parameter
        private int addTwoInteger(int value1, int value2 = 0)
        {
            int result = value1 + value2;
            return result;
        }


    }
}
