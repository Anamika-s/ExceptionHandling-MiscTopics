using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_MiscTopics
{
    internal static class MainClassExtended
    {
        public static bool FirstLetterStartsWithA(this String str1,  string str2)
        {
            if (str2.StartsWith("A"))
                return true;
            else 
                return false;
        }
        public static string ReveseString(this MainClass mainClass,
            string str)
        {
            return str;
        }
        public static bool NumberMoreThan5(this Int16 int16,
           int num)
        {
            if (num > 5) return true;
            else return false;

        }
    }
}
