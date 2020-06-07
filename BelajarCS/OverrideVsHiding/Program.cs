using System;


namespace BelajarCS.WritingMyFirstCode
{

    public class Base
    {
        public void Print()
        {
            Console.WriteLine("i am base class");
        }
    }

    public class KelasTurunan : Base
    {
        public new void Print()
        {
            Console.WriteLine("i am kelas turunan class");
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Base a = new KelasTurunan();
            a.Print();

            KelasTurunan d = new KelasTurunan();
            d.Print();
        }
    }
}
