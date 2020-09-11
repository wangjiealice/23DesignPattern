using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class Shape : IShape
    {
        protected IColor color;

        public void SetColor(IColor color)
        {
            this.color = color;
        }

        public virtual void Draw()
        {
        }
    }
}
