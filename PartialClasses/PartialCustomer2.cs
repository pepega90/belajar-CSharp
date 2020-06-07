using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomer2
    {
        public string getFullName()
        {
            return _fn + " " + _ln;
        }
    }
}