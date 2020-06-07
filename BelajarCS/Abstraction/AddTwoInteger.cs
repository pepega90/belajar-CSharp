using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Abstraction
{
    class AddTwoInteger : AdditionClass
    {
        private int _total;
        public override object Total
        {
            get { return _total; }
        }

        public AddTwoInteger(int value1, int value2)
        {
            _total = (int)this.AddTwoValues(value1, value2);
        }

        protected override object AddTwoValues(object Value1, object Value2)
        {
            int sum = (int)Value1 + (int)Value2;
            return sum;
        }
    }
}
