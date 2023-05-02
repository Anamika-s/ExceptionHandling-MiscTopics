using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_MiscTopics
{
    internal partial class PartialClass
    {
        partial void GetA();
        partial void GetB();
        partial void GetC();
        public void CallMethods()
        {
            GetA();
            GetB();
        }


    }
}
