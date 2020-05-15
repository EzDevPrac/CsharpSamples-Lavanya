using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingUnity
{
    public interface IInstitutionService
        {
            Institution GetInstitutionByID(long institutionID);
        }
    
}
