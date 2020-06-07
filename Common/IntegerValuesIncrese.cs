﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    class IntegerValuesIncrese : IValueIncrese<int>
    {
        public int Value1 { get; set; }
        public int Value2 { get ; set; }

        public IntegerValuesIncrese(int val1, int val2)
        {
            Value1 = val1;
            Value2 = val2;
        }

        public int Product()
        {
            return Value1 * Value2;
        }

        public int Sum()
        {
            return Value1 + Value2; 
        }
    }
}
