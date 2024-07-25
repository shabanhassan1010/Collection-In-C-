using Collection_In_C_.SortedSet_Of_Objects;
using System.Collections.Generic;

namespace Collection_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  SortedSet Of Objects

            //SortedSet<City> cities = new SortedSet<City>()
            //{ 
            //    new City ( 1 , "Cairo" , "Egypt" , 12121212 ),
            //    new City ( 1 , "Alex" , "Egypt" , 32332 ),
            //    new City ( 1 , "Behira" , "Egypt" , 232315 ),
            //    new City ( 1 , "Mansoura" , "Egypt" , 454545 ),
            //};

            //foreach(var city in cities)
            //{
            //    Console.WriteLine(city.ToString());
            //}
            //Console.WriteLine();

            //foreach (var city in cities)
            //{
            //    Console.WriteLine($"Popluation: {city.Popluation} , Country: {city.Country} , Name: {city.Name}");
            //}

            #endregion

            #region Generic SortedDictionary

            //SortedDictionary<string, City> cities = new SortedDictionary<string, City>()
            //{

            //{ "s", new City(1, "ssss", "Egypt" , 32121) },
            //{ "b", new City(1, "ssss", "Egypt" , 32121) },
            //{ "a", new City(1, "ssss", "Egypt" , 32121) }

            //};
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //    Console.WriteLine(city.Key);
            //}

            //// OutPut 
            //// [a, ssss, Egypt -Population: 32121]  // he sorted by key >>>> a
            //// [b, ssss, Egypt -Population: 32121]  // b 
            //// [s, ssss, Egypt -Population: 32121]  // s


            #endregion
        }
    }
}
