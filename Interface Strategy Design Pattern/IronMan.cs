using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Strategy_Design_Pattern
{
    class IronMan : TheAvengers
    {

        public IronMan(IFly fly) : base(fly) 
        {
        }

    }
}
