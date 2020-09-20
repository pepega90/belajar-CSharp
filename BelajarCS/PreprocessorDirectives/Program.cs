#define PI
using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.PreprocessorDirectives
{
    class Program
    {
        /* Preprocessor Directive, memberikan instruksi kepada compiler untuk memproses informasi sebelum kompilasi aktual dimulai.
         */
        static void Main()
        { 
        #if (PI)
            Console.WriteLine("PI is defined");
        #else
            Console.WriteLine("PI not defined");
        #endif
        }
    }
}
