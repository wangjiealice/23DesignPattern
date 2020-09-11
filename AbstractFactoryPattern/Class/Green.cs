using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
