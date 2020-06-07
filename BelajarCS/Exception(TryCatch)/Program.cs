using System;
using System.IO;
using System.Linq;

namespace BelajarCS.TryCatch.Program
{
    /* Exception handling
     * exception adalah error yang terjadi ketika program berjalan
     * contohnya:
     * membaca file yang tidak ada, akan memberikan FileNotFoundException
     * membacar database table yang tidak ada, akan memberikan SqlException
     * Exception sebenarnya adalah class dari System.Exception class, yang mempunyai beberapa 
     * properti yang berguna. seperti;
     * Message: pesan yang terjadi dari exception error
     * Stack Trace: memberi tahu baris code yang throwing exception
     */
   
    class Program
    {
     
        static void Main(string[] args)
        {
            StreamReader readFile = null;
            try
            {
                readFile = new StreamReader(@"C:\testing\Data.txt");
                Console.WriteLine(readFile.ReadToEnd());
                
            }
            // Exception yang spesifik, sebisa mungkin lebih awal
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Tolong cek kembali file {0} anda", e.FileName);
                Console.WriteLine();
            }
            // General exception baru setelah semua exception yang spesifik
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Finallny block, block dimana kita ingin free resource. maksudnya adalah, ketika
            // kode yang di try block itu melempar exception. itu artinya dia akan masuk ke catch block
            // dan kode tersebut tidak akan selesai, karena catch block melempar exception. dengan finally
            // kode tersebut bisa tetap dijalakan walaupun tidak ada exception sekalipun
            // Catatan : finally block tidak selalu wajib digunakan
            finally 
            {
                if(readFile != null)
                {
                    readFile.Close();
                }
                Console.WriteLine("Finally block");
            }
        }
    }
}
