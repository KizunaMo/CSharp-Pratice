using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class AddOnDecorater:Beverage
    {
        public override int Cost()
        {
            return 1;
        }
    }
}
