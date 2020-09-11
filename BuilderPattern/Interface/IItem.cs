using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BuilderPattern
{
    public interface IItem
    {
        string Name();

        IPacking Packing();

        float Price();
    }
}
