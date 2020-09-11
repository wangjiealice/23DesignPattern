using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
