using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.EnumExample
{
    /* Enum, adalah strong type constans
     * enum is value type
     * enum adalah enumerations
     * default value index enum adalah 0, dan setiap next value di increment by 1
     */
    class Program
    {
        static void Main()
        {
            Customer[] customer = new Customer[3];

            customer[0] = new Customer
            {
                Name = "mark",
                Gender = Gender.Male
            };

            customer[1] = new Customer
            {
                Name = "meri",
                Gender = Gender.Female
            };

            customer[2] = new Customer
            {
                Name = "sam",
                Gender = Gender.Unknown
            };

            foreach (Customer item in customer)
            {
                Console.WriteLine("Name = {0} & Gender = {1}", item.Name, GetGender(item.Gender));
            }
        }

        public static string GetGender(Gender genderInt)
        {
            switch (genderInt)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data deteced";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        /* 0 = Unknown
         * 1 = Male
         * 2 = Female
         */
        public Gender Gender { get; set; }
    }
}
