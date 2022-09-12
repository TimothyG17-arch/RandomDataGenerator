using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class SSN
    {
        //https://secure.ssa.gov/poms.nsf/lnx/0110201035
        Int32[] Social;
        Random Second = new Random();
        public SSN{
            Int32 Two = Second.Next(1,100);
        }

    }

}
