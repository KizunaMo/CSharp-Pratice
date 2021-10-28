using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
}
