using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.TypeVsTypesMember
{
    /* Secara umum class, struct, enum, interface, delegate disebut types.
     * field, properti, constructor, method etc disebut type member
     * di C# ada 5 access modifer
     * 1. Private
     * 2. Protected
     * 3. Internal
     * 4. Protected Internal
     * 5. Public
     * 
     * type member bisa memilki semua access modifier, sedangkan types hanya bisa memiliki 2 saja yaitu internal dan public
     */
     public class Customer
    {
        // Region, digunakan untuk meng-group code kita, agar bisa di collapsing
        #region Fields
        private int _id;
        private string _firstName;
        private string _lastName;
        #endregion

        #region Properti
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Methods
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        #endregion
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
