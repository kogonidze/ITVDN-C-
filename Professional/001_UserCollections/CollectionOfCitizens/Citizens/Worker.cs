using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Citizens
{
    class Worker : Citizen
    {
        public string OrganizationName { get; set; }

        public Worker(int passportID, string firstName, string lastName, int yearOfBirth, string organizationName)
            : base(passportID, firstName, lastName, yearOfBirth)
        {
            OrganizationName = organizationName;
        }
    }
}
