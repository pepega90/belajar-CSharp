using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Interfaces
{
    class UpdateInteger : IValueIncrese<int>
    {
        public int Value1 { get ; set ; }
        public int Value2 { get ; set ; }

        public UpdateInteger(int val1, int val2)
        {
            Value1 = val1;
            Value2 = val2;
        }

        public int Product()
        {
            return Value2 * Value1;
        }

        public int Sum()
        {
            return Value2 + Value1;
        }
    }
}
