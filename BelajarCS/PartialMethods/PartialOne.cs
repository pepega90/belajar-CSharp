using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.PartialMethods
{
    public partial class SamplePartial
    {
        // definisi
        partial void SampleMethod();
        // implementasi
        partial void SampleMethod()
        {
            Console.WriteLine("sample method invoke");
        }

        public void PublicMethod()
        {
            Console.WriteLine("public method invoke");
            SampleMethod();
        }
    }
}
