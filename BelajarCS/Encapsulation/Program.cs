using System;
using System.Linq;

namespace BelajarCS.Encapsulation.Program
{

    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;


        /* jika kita tidak memiliki semacam logic untuk set value atau pun get value.
         * kita bisa menggunakan auto implement property. dimana compiler secara tidak langsung membuat private field
         * yang kita akses melalui get dan set accessor, melalui property. contoh di bawah ini
         */
        public string City { get; set; }
        public string Email { get; set; }

        /* jika properti memiliki get dan set akses, artinya itu adalah read/write properti
        * hanya get berarti read properti. set saja berarti write properti
        */


        // properti biasanya di gunakan untuk melakukan encapsulation, dimana kita mempunyai
        // private field yang hanya bisa akses di get accessor dan 
        // bisa di set valuenya melalui set accessor
        public int passMark
        {
            get
            {
                return this._passMark;
            }
        }


        public string Name
        {
            //setter
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nama tidak bisa kosong");
                }
                this._name = value;
            }
            // getter
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int id
        {
            // jika kita ingin memberikan value untuk properti,
            // set memiliki "value" keyword yang secara default adalah value yang di passing dari instance object
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id tidak bisa negatif");
                }
                this._id = value;
            }
            // get accessor, ketika kita ingin melihat value yang di set dari set accessor
            get
            {
                return this._id;
            }
        }

    }

    class Program
    {
        static void Main()
        {
            Student c = new Student();
            c.id = 101;
            c.Name = "Aji";


            Console
                .WriteLine("Id {0}, name {1}, passmark {2}",
                c.id, c.Name, c.passMark);
        }
    }
}
