using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Citizens
{
    class Student : Citizen
    {
        public string UniversityName { get; set; }

        public Student(int passportID, string firstName, string lastName, int yearOfBirth, string universityName)
            : base(passportID, firstName, lastName, yearOfBirth)
        {
            UniversityName = universityName;
        }
    }
}
