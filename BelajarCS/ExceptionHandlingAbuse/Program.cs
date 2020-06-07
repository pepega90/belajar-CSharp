using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.ExceptionHandlingAbuse
{
    class Program
    {
        static void Main()
        {
            // Exception abuse, ketika kita terlalu sering menggunakan exception di catch block.
            // sebenarnya tidak salah dan kode kita pun tidak akan terkena compile error,
            // namun lebih balik melakukan cek kepada kode kita lagi, agar terhindar dari spesifik exception
            try
            {
                Console.Write("Please enter numerator = ");
                int num;
                bool isNumerator = int.TryParse(Console.ReadLine(), out num);
                
                // contoh kita prevent exception handling abuse
                if (isNumerator)
                {

                    Console.Write("Please enter denominator = ");
                    int deno;
                    bool isDenominator = int.TryParse(Console.ReadLine(), out deno);

                    if (isDenominator && deno != 0)
                    {
                        int result = num / deno;

                        Console.WriteLine("Result = {0}", result);
                    }
                    else
                    {
                        if (deno == 0)
                        {
                            Console.WriteLine("Denominator tidak bisa kosong");
                        }
                        else
                        {
                        Console
                        .WriteLine
                        ("Denominator should be a valid number between {0} dan {1}",
                        int.MinValue, int.MaxValue);
                        }
                    }

                }
                else
                {
                    Console
                        .WriteLine
                        ("Numerator should be a valid number between {0} dan {1}",
                        int.MinValue, int.MaxValue);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
