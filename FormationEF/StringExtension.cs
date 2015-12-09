using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    // cette classe est une extension de la classe string : rajoute la methode ToUpperFirstLetter à la classe de base string.
    public static class StringExtension
    {
        public static string ToUpperFirstLetter(this String s)
        {
            string result = s.First().ToString().ToUpper();
            result += s.Substring(1).ToLower();

            return result;
        }
    }
}
