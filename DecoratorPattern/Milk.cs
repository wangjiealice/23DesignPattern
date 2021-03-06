﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Milk : Decorator
    {
        private Beverage beverage;
        public Milk(Beverage bev)
        {
            beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", milk";
        }

        public override float Cost()
        {
            return beverage.Cost() + 10.0f;
        }
    }
}
