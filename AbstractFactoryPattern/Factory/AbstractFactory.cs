using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(String color);
        public abstract IShape GetShape(String shape);
    }
}
