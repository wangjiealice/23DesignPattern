using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Package a Wrapper";
        }
    }
}
