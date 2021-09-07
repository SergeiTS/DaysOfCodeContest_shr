using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class RegExPatternsDB
    {
        public static string GetName(string firstName, string emailID)
        {
            //string patternName = @"^.*\s";
            string patternMail = @"^.*@gmail.com";
            Regex rgxMail = new Regex(patternMail, RegexOptions.IgnoreCase);
            //Regex rgxName = new Regex(patternName, RegexOptions.IgnoreCase);

            if (rgxMail.IsMatch(emailID))
            {
                return firstName;
                //nameR = rgxName.Match(name).ToString();
            }
            return null;
        }

    }
}
