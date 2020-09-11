using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
