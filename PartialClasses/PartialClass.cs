using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public class PartialClass
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

        public string lastName
        {
            get
            {
                return _ln;
            }
            set
            {
                _ln = value;
            }
        }

        public string getFullName()
        {
            return _fn + " " + _ln;
        }
    }


}