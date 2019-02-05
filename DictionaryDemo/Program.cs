using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> capitals = new Dictionary<string, string>();

            //capitals.Add("Northern Ireland", "Belfast");
            //capitals.Add("Ireland", "Dublin");
            //capitals.Add("England", "London");
            //capitals.Add("Wales", "Cardiff");

            //string CapitalOfNI = capitals["Northern Ireland"];
            //Console.WriteLine(CapitalOfNI);

            var theCountries = Country.GetCountries();

            string capitalOfNI = theCountries["NI"].Capital;
            Console.WriteLine(capitalOfNI);

        }
    }
}
