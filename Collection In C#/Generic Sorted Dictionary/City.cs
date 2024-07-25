using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_In_C_.Generic_Sorted_Dictionary
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Popluation { get; set; }

        public City(int id, string name, string country, int popluation)
        {
            Id = id;
            Name = name;
            Country = country;
            Popluation = popluation;
        }
    }
}
