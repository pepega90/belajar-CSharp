using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        // jika suatu member class diberikan keyword virtual, itu artinya kelas turunannya 
        // bisa melakukan override terhadap member tersebut
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTime : Employee
    {
        // jika kita ingin meng-override member di base class yang sudah diberikan keyword virtual
        // kita bisa memberikan keyword override setelah access modifier
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class FullTime : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - FullTime");
        }
    }

    public class TemporaryEmployee : Employee
    {
        
    }

    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTime();
            employees[2] = new FullTime();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
