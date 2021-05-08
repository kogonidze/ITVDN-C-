using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword.Constants
{
    abstract class PatternConstants
    {
        public const string patternForLogin = @"^[a-z]+$";

        public const string patternForPassword = @"^[a-z0-9]+$";
    }
}
