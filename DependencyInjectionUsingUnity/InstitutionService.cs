using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingUnity

{
    public class InstitutionService : IInstitutionService
        {
            public Institution GetInstitutionByID(long institutionID)
            {
                return new Institution
                {
                    InstitutionID = institutionID,
                    Name = " NCET",
                    Address = "Bangalore",
                    Telephone = "0123456789"
                };
            }
        }
}

