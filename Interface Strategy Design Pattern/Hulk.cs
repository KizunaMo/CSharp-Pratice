using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Strategy_Design_Pattern
{
    class Hulk :TheAvengers
    {

        public Hulk(IFly fly):base(fly)
        {
        }
    }
}
