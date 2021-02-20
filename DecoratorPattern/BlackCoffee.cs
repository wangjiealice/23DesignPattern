using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BlackCoffee : Beverage
    {
        public BlackCoffee()
        {
            description = "BlackCoffee";
        }

        public override float Cost()
        {
            return 22.0f;
        }
    }
}
