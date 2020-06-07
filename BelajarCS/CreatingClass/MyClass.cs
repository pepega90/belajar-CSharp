using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.CreatingClass
{
    class MyClass
    {
        // disini kita membuat variabel
        private int _value1;
        private int _value2;

        /* property get = berguna untuk menerima nilai dari suatu variabel (biasanya variabelnya private)
         * property set = berguna untuk kita mengubah niali dari suatu variabel (biasanya variabelnya private)
         */
        public int Value1
        {
            get { return _value1; }
            set { _value1 = value; }
        }

        public int Value2
        {
            set { _value2 = value; }
        }

       // disini kita mendeklarasi method (functions)
       public void doMath()
        {
            // this keyword, itu merefrensikan ke class saat ini (current class)
            Console.WriteLine(addTwoInteger(this.Value1, _value2));
        }
        // default parameter, tidak bisa digunakan di required parameter
        private int addTwoInteger(int value1, int value2 = 0)
        {
            int result = value1 + value2;
            return result;
        }
    }
}
