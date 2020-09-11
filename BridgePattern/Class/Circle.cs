using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw " + color.Name() + " circle.");
        }
    }
}
