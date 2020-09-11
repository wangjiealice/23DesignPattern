using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
