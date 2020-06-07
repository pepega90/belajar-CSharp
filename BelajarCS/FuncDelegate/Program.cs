using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelajarCS.FuncDelegate
{
    /* Func<T, TResult> in C#?
     * secara sederhana, Fungsi <T, TResult> adalah generic delegate. tergantung pada persyaratan, parameter tipe (T dan TResult) dapat diganti dengan argumen tipe yang sesuai.
     * T = input parameter
     * TResult = return parameter
     */
    class Program
    {
        static void Main()
        {
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee{ID = 101, Name = "Mark" },
                new Employee{ID = 102, Name = "John" },
                new Employee{ID = 103, Name = "Mary" }
            };

            //Func<Employee, string> selector = employee => "Name = " + employee.Name;
            // kita juga bisa lansung memberikan lambda expression ke Select method, karena Select method berasal dari LINQ
            IEnumerable<string> names = listEmployee.Select(employee => "Name = " + employee.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            // Bagaimana jika kita ingin menginput lebih parameter?
            // Func memiliki 17 overload, dimana disetiap overloadnya kita bisa memberikan lebih parameter
            Func<int, int, string> pertambahan = (num1, num2) => "Pertambahan = " + (num1 + num2).ToString();
            string hasil = pertambahan(5, 5);
            Console.WriteLine(hasil);

        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
