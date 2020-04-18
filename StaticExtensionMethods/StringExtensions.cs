using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionMethods
{
    /*
     * Static class to act as a holder for static methods
     * (should not and can not be instantiated)
     */
    public static class StringExtensions
    {
        /*
         * Extension method for strings which converts the first letter
         * of a string to upper case
         */
        public static string FirstLetterUpperCase(this string word)
        {
            char letter = Char.ToUpper(word[0]);
            string remaining = word.Substring(1);

            return letter + remaining;
        }
    }
}
