using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        private string _fn;
        private string _ln;

        public string firstName
        {
            get
            {
                return _fn;
            }
            set
            {
                _fn = value;
            }
        }
    }
}