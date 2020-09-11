using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
