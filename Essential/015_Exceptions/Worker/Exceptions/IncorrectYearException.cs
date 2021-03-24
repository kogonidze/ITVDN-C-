using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Exceptions
{
    public class IncorrectYearException : Exception
    {
        public IncorrectYearException()
            : base("You entered incorrect value of the year!")
        {

        }
    }
}
