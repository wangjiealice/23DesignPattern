using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public virtual string Name() { return ""; }

        public virtual float Price() { return 0; }

        public IPacking Packing()
        {
            return new Bottle();
        }
    }
}
