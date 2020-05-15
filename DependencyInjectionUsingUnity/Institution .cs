using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingUnity
{
    public class Institution
    { 
            public long InstitutionID { get; set; }
            public string Name { get; set; }
            public string Telephone { get; set; }
            public string Address { get; set; }

        public override string ToString()
        {
            return "Institution id :" + InstitutionID + "\n Name :" + Name + "\n Telephone :" + Telephone + "\n Address :" + Address;
        }

    }
}
