using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Models
{
    public class Countries
    {
        public static Countries Current { get; } = new Countries();

        public List<CountryData> countries { get; set; }
    }
}
