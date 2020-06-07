using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Encapsulation
{
    class MyClass
    {

        private int _total;

        public int Total
        {
            get { return _total; }
            //set { _total = value; }
        }


        public MyClass(int Value1, int Value2)
        {
            _total = addTwoInteger(Value1, Value2);
        }


        // default parameter, tidak bisa digunakan di required parameter
        private int addTwoInteger(int value1, int value2 = 0)
        {
            int result = value1 + value2;
            return result;
        }


    }
}
