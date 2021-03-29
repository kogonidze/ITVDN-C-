using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Citizens
{
    class Retiree : Citizen
    {
        public Retiree(int passportID, string firstName, string lastName, int yearOfBirth)
            : base(passportID, firstName, lastName, yearOfBirth)
        {

        }
    }
}
