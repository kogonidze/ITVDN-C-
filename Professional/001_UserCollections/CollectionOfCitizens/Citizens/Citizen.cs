using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Citizens
{
    abstract class Citizen
    {
        public int PassportID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int YearOfBirth { get; } 

        public Citizen(int passportID, string firstName, string lastName, int yearOfBirth)
        {
            PassportID = passportID;
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Citizen))
            {
                return false;
            }

            var citizen = obj as Citizen;

            if (this.PassportID == citizen.PassportID)
            {
                return true;
            }

            return false;

        }

        public override int GetHashCode()
        {
            return PassportID;
        }

        public static bool operator ==(Citizen firstCitizen, Citizen secondCitizen)
        {
            if (firstCitizen.Equals(secondCitizen))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Citizen firstCitizen, Citizen secondCitizen)
        {
            if (firstCitizen.Equals(secondCitizen))
            {
                return false;
            }

            return true;
        }
    }
}
