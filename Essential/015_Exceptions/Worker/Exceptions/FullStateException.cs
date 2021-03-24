using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class FullStateException : Exception
    {
        public FullStateException() 
            : base("There is full state in our company! You can not hire anyone!")
        {

        }
    }
}
