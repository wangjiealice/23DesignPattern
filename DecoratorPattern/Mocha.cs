using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Mocha : Decorator
    {
        private Beverage beverage;
        public Mocha(Beverage bev)
        {
            beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", mocha";
        }

        public override float Cost()
        {
            return beverage.Cost() + 8.0f;
        }
    }
}
