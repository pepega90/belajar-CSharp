using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BelajarCS.InnerException
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.Write("Enter first number = ");
                    int fn = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Second number = ");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;

                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception e)
                {
                    string filepath = @"D:\exceptionLog\Log.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(e.GetType().Name);
                        sw.WriteLine();
                        sw.Write(e.Message);
                        sw.Close();
                        Console.WriteLine("Telah terjadi error");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " tidak ada", e);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Current exception = {0}", ex.GetType().Name);
                if(ex.InnerException != null)
                {
                    Console.WriteLine("Inner exception = {0}", ex.InnerException.GetType().Name);
                }
                
            }
        }
    }
}
