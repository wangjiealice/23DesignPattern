using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Latte : Beverage
    {
        public Latte()
        {
            description = "Latte";
        }

        public override float Cost()
        {
            return 28.0f;
        }
    }
}
