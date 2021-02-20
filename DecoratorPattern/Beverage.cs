using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class Beverage
    {
        protected string description = "Known Beverage.";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract float Cost();
    }
}
