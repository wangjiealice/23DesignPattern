using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            if (shape.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shape.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shape.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
