using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_In_C_.SortedSet_Of_Objects
{
    public class City : IComparable<City>
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

        public int CompareTo(City city)
        {
            if (this.Popluation > city.Popluation)
                return 1;
            else if (this.Popluation < city.Popluation)
                return -1;
            else
                return 0;
        }
        // [override] : This keyword indicates that the method overrides a base class method.
        // In this case, it overrides the ToString method defined in the Object class, which is the base class for all .NET types.
        public override string ToString()
        {
            return $"{Name}, {Country} - Population: {Popluation}";
        }
    }
}
