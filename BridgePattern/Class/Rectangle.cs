using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw " + color.Name() + " rectangle.");
        }
    }
}
