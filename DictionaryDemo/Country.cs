using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class Country
    {
        public String Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        public Country(string capital, int pop, int size)
        {
            Capital = capital;
            Population = pop;
            Size = size;
        }

        public static Dictionary<String, Country> GetCountries()
        {
            var Countries = new Dictionary<string, Country>();
            var theCountry = new Country("Belfast", 123456, 123);
            Countries.Add("NI", theCountry);

            theCountry = new Country("London", 567890, 543);
            Countries.Add("England", theCountry);

            return Countries;
        }
    }
}
