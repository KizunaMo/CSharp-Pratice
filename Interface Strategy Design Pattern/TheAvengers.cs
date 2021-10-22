using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Strategy_Design_Pattern
{
    class TheAvengers:IFly
    {
        private IFly flyBehavior;

        public TheAvengers(IFly flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void FlyMethod()
        {
            this.flyBehavior.FlyMethod();
        }
        public void FlyMethod1()
        {
            flyBehavior.FlyMethod();
        }


    }
}
