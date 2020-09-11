using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(String choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
