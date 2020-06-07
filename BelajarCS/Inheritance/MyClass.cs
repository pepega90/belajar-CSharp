using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Inheritance
{
    class MyClass
    {

        private int _total;

        // virtual (keyword), memungkinkan kita untuk bisa meng-override atau menimpa value dari suatu
        // property atau pun method
        public virtual int Total
        {
            get { return _total; }
            //set { _total = value; }
        }


        public MyClass(int Value1, int Value2)
        {
            _total = addTwoInteger(Value1, Value2);
        }


        // default parameter, tidak bisa digunakan di required parameter
        // protected access modifier, ketika suatu method atau property dari kelas base di berikan akses protected
        // itu artinya tersedia untuk kelas turunanya
        protected virtual int addTwoInteger(int value1, int value2 = 0)
        {
            int result = value1 + value2;
            return result;
        }


    }
}
