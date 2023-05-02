using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_MiscTopics
{
    internal class MainClass
    {
        public  int StringLength(string str)
        {
            return str.Length;
        }
        public string JoinStrings(string str1, string str2)
        {
            return str1.Concat(str2).ToString();
        }
    }

    //static class IntExtended
    //{
    //    public static bool NumberMoreThan5(this Int16 int16, 
    //        int num)
    //    {
    //        if (num > 5) return true;
    //        else return false;

    //    }
    //    }
    }
