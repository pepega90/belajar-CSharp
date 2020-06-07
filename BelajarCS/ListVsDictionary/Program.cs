using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.ListVsDictionary
{
    /* Part 81
     * Disini kita membahas kapan Dictionary digunakan daripada List di C#
     * jika kita ingin mencari nilai menggunakan keys, dictionary memiliki kinerja lebih baik daripada list
     */
    class Program
    {
        static void Main()
        {
            Country country1 = new Country { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country { Code = "IND", Name = "INDONESIA", Capital = "Jakarta" };
            Country country3 = new Country { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C" };
            Country country4 = new Country { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            // Contoh program menggunakan list
            //List<Country> listCountries = new List<Country>();
            //listCountries.Add(country1);
            //listCountries.Add(country2);
            //listCountries.Add(country3);
            //listCountries.Add(country4);
            //listCountries.Add(country5);

            //string userChoice;
            //do
            //{
            //    Console.WriteLine("Please enter country code \n= ");
            //    string codeStr = Console.ReadLine().ToUpper();

            //    Country resultCountry = listCountries.Find(c => c.Code == codeStr);
            //    if (resultCountry == null)
            //    {
            //        Console.WriteLine("Country code not valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            //    }

            //    do
            //    {
            //        Console.WriteLine("Do You want to continue - YES or NO ?");
            //        userChoice = Console.ReadLine().ToUpper();
            //    } while (userChoice != "NO" && userChoice != "YES");

            //} while (userChoice == "YES");

            // Contoh Program menggunakan Dictionary
            Dictionary<string,Country> dictCountries = new Dictionary<string, Country>();
            dictCountries.Add(country1.Code, country1);
            dictCountries.Add(country2.Code, country2);
            dictCountries.Add(country3.Code, country3);
            dictCountries.Add(country4.Code, country4);
            dictCountries.Add(country5.Code, country5);

            string userChoice;
            do
            {
                Console.WriteLine("Please enter country code \n= ");
                string codeStr = Console.ReadLine().ToUpper();

                Country resultCountry = dictCountries.ContainsKey(codeStr) ? dictCountries[codeStr] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
                }

                do
                {
                    Console.WriteLine("Do You want to continue - YES or NO ?");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "NO" && userChoice != "YES");

            } while (userChoice == "YES");
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
