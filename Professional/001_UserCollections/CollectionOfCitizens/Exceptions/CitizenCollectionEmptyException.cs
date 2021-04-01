using CollectionOfCitizens.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfCitizens.Exceptions
{
    class CitizenCollectionEmptyException : Exception 
    {
        public CitizenCollectionEmptyException()
            : base(ErrorMessages.CitizensCollectionEmptyErrorMessage)
        {

        }
    }
}
