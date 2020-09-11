using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Package a Bottle";
        }
    }
}
