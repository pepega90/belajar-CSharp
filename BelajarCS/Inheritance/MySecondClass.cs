using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Inheritance
{
    class MySecondClass : MyClass
    {
        private int _total;
        private int _maxTotal;

        // override (keyword), override yang memungkin kita untuk menimpa value dari property 
        // atau method yang sudah di berikan virtual access
        public override int Total
        {
            get { return _total; }
        }


        public MySecondClass(int value1, int value2, int maxTotal) : base(value1, value2)
        {
            _maxTotal = maxTotal;
            _total = this.addTwoInteger(value1, value2);
        }
        protected override int addTwoInteger(int value1, int value2)
        {
            int result = base.addTwoInteger(value1, value2);
            if (result > _maxTotal)
                result = _maxTotal;
            return result;
        }
    }
}
