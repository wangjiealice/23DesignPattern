using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
