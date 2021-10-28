using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Soy:AddOnDecorater
    {
        Beverage beverage;
        int number = 0;

        public Soy(int number,Beverage beverage)
        {
            this.beverage = beverage;
            this.number = number;
        }


        public override int Cost()
        {
            return this.beverage.Cost() + (3*number);
        }
    }
}
