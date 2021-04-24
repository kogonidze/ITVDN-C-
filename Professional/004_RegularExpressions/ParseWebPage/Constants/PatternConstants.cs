using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseWebPage.Constants
{
    abstract class PatternConstants
    {
        public const string patternForLinks = @"http[s]?://[a-zA-Z0-9а-яА-Я./]*";

        public const string patternForPhoneNumber = @"[+]?[0-9()]{12,14}";

        public const string patternForEmail = @"[a-zA-Z0-9а-яА-Я]+@[a-zA-Z0-9а-яА-Я]+\.[a-zA-Z0-9а-яА-Я]+";
    }
}
