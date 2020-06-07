using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace BelajarCS.ReflectionLateBinding
{
    /* Early binding, beberapa error bisa di deteksi saat compile time
     * Late binding, kita lakukan ketika kita tidak tau apa-apa tentang suatu class
     */
    class ReflectionLateBinding
    {
        static void Main()
        {
            Assembly executingAsambel = Assembly.GetExecutingAssembly();

            Type customer = executingAsambel.GetType("BelajarCS.ReflectionLateBinding.Customer");

            object customerInstance = Activator.CreateInstance(customer);

            MethodInfo getFullNameMethod = customer.GetMethod("GetFullName");

            string[] parameter = new string[2];
            parameter[0] = "aji";
            parameter[1] = "mustofa";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameter);
            Console.WriteLine("full name = {0}", fullName);

            // Contoh Early binding
            //Customer c1 = new Customer();
            //string fullName = c1.GetFullName("aji", "mustofa");
            //Console.WriteLine("full name = {0}", fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string fn, string ln)
        {
            return fn + " " + ln;
        }
    }
}
