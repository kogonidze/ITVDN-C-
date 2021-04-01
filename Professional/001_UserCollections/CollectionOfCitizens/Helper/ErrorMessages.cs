using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Helper
{
    abstract class ErrorMessages
    {
        public const string CitizensDuplicationAttemptErrorMessage = 
            "You are trying to add new citizen with existing passport ID!";

        public const string CitizenNotFoundErrorMessage =
            "There is no such citizen in collection";

        public const string CitizensCollectionEmptyErrorMessage =
            "Citizen collection is empty";
    }
}
